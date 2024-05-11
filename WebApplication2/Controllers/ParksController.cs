using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace WebApplication2.Controllers
{
    public struct GeoCoordinate
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double DistanceTo(GeoCoordinate other)
        {
            var r = 3959; // Earth radius in miles
            var dLat = ToRadians(other.Latitude - this.Latitude);
            var dLon = ToRadians(other.Longitude - this.Longitude);
            var lat1 = ToRadians(this.Latitude);
            var lat2 = ToRadians(other.Latitude);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return r * c;
        }

        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }

    public record ParkData(string Code, string Name, string Url, string Description, GeoCoordinate location, double distance);

    public sealed class NpsClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;

        public NpsClient(HttpClient httpClient, ILogger logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        private static ReadOnlyDictionary<string, string> states = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
        {
            {"AL", "Alabama"},
            {"AK", "Alaska"},
            {"AZ", "Arizona"},
            {"AR", "Arkansas"},
            {"CA", "California"},
            {"CO", "Colorado"},
            {"CT", "Connecticut"},
            {"DE", "Delaware"},
            {"FL", "Florida"},
            {"GA", "Georgia"},
            {"HI", "Hawaii"},
            {"ID", "Idaho"},
            {"IL", "Illinois"},
            {"IN", "Indiana"},
            {"IA", "Iowa"},
            {"KS", "Kansas"},
            {"KY", "Kentucky"},
            {"LA", "Louisiana"},
            {"ME", "Maine"},
            {"MD", "Maryland"},
            {"MA", "Massachusetts"},
            {"MI", "Michigan"},
            {"MN", "Minnesota"},
            {"MS", "Mississippi"},
            {"MO", "Missouri"},
            {"MT", "Montana"},
            {"NE", "Nebraska"},
            {"NV", "Nevada"},
            {"NH", "New Hampshire"},
            {"NJ", "New Jersey"},
            {"NM", "New Mexico"},
            {"NY", "New York"},
            {"NC", "North Carolina"},
            {"ND", "North Dakota"},
            {"OH", "Ohio"},
            {"OK", "Oklahoma"},
            {"OR", "Oregon"},
            {"PA", "Pennsylvania"},
            {"RI", "Rhode Island"},
            {"SC", "South Carolina"},
            {"SD", "South Dakota"},
            {"TN", "Tennessee"},
            {"TX", "Texas"},
            {"UT", "Utah"},
            {"VT", "Vermont"},
            {"VA", "Virginia"},
            {"WA", "Washington"},
            {"WV", "West Virginia"},
            {"WI", "Wisconsin"},
            {"WY", "Wyoming"}
        });

        private static GeoCoordinate GetCityCoordinate(JsonElement cityElement)
        {
            double latitude = cityElement.GetProperty("latitude").GetDouble();
            double longitude = cityElement.GetProperty("longitude").GetDouble();

            return new GeoCoordinate(latitude, longitude);
        }

        public async Task<List<ParkData>> GetParks(string cityName, string stateCode, CancellationToken cancellationToken)
        {
            GeoCoordinate cityCoordinate;
            {
                if (!states.TryGetValue(stateCode, out string state))
                {
                    throw new ArgumentException("State is incorrect: " + stateCode);
                }

                string geoApiUrl = $"https://api.api-ninjas.com/v1/geocoding?city={cityName}&country=US";
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, geoApiUrl);
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("X-Api-Key", "kG3mOf7nK1Mxc3enWfRwHA==hhP3032rTRGKEQwl");
                HttpResponseMessage response = await _httpClient.SendAsync(request, cancellationToken);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JsonDocument jd = JsonDocument.Parse(responseBody);
                JsonElement root = jd.RootElement;
                var cityElement = root.EnumerateArray()
                    .FirstOrDefault(x => x.GetProperty("name").GetString().Equals(cityName) && x.GetProperty("state").GetString().Equals(state));
                if (cityElement.ValueKind == JsonValueKind.Undefined || cityElement.ValueKind == JsonValueKind.Null)
                {
                    throw new InvalidOperationException("City not found: " + cityName);
                }

                cityCoordinate = GetCityCoordinate(cityElement);
            }

            {
                string parksUrl = $"https://developer.nps.gov/api/v1/parks?stateCode={stateCode}";
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, parksUrl);
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("X-Api-Key", "zdNFN0io4o8airhiCo3j2rnyoULuEUAjfK6cLtPC");
                HttpResponseMessage response = await _httpClient.SendAsync(request, cancellationToken);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JsonDocument jd = JsonDocument.Parse(responseBody);
                JsonElement data = jd.RootElement.GetProperty("data");

                var parks = new List<ParkData>();
                foreach (JsonElement park in data.EnumerateArray())
                {
                    double latitude = Convert.ToDouble(park.GetProperty("latitude").GetString());
                    double longitude = Convert.ToDouble(park.GetProperty("longitude").GetString());
                    var parkData = new ParkData(
                        park.GetProperty("parkCode").GetString(),
                        park.GetProperty("fullName").GetString(),
                        park.GetProperty("url").GetString(),
                        park.GetProperty("description").GetString(),
                        new GeoCoordinate(latitude, longitude),
                        new GeoCoordinate(latitude, longitude).DistanceTo(cityCoordinate)
                        );
                    parks.Add(parkData);
                }

                var result = parks
                    .OrderBy(x => x.distance)
                    .Take(3)
                    .ToList();

                return result;
            }
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class ParksController : ControllerBase
    {
        private readonly ILogger<ParksController> _logger;
        private readonly NpsClient _apiClient;

        public ParksController(NpsClient apiClient, ILogger<ParksController> logger)
        {
            _logger = logger;
            _apiClient = apiClient;
        }

        [HttpGet(Name = "GetParks")]
        public IEnumerable<ParkData> Get(string city, string state)
        {
            var result = _apiClient.GetParks("Waltham", "MA", CancellationToken.None).Result;
            return result;
        }
    }
}
