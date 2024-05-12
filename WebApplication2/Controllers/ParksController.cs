using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Assessment.Controllers
{
    public sealed class NpsApiClient
    {
        private const string ApiKey = "zdNFN0io4o8airhiCo3j2rnyoULuEUAjfK6cLtPC";
        private readonly HttpClient _httpClient;
        private readonly ILogger<NpsApiClient> _logger;

        public NpsApiClient(HttpClient httpClient, ILogger<NpsApiClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<HttpResponseMessage> GetParks(string stateCode, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Calling NPS API for {stateCode}");
            string parksUrl = $"https://developer.nps.gov/api/v1/parks?stateCode={stateCode}";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, parksUrl);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("X-Api-Key", ApiKey);
            HttpResponseMessage response = await _httpClient.SendAsync(request, cancellationToken);

            return response;
        }
    }

    public sealed class GeoLocationClient
    {
        private const string ApiKey = "kG3mOf7nK1Mxc3enWfRwHA==hhP3032rTRGKEQwl";
        private readonly HttpClient _httpClient;
        private readonly ILogger<GeoLocationClient> _logger;

        public GeoLocationClient(HttpClient httpClient, ILogger<GeoLocationClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<HttpResponseMessage> GetCityLocation(string cityName, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Calling Geo location API for {cityName}");
            string geoApiUrl = $"https://api.api-ninjas.com/v1/geocoding?city={cityName}&country=US";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, geoApiUrl);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("X-Api-Key", ApiKey);
            HttpResponseMessage response = await _httpClient.SendAsync(request, cancellationToken);

            return response;
        }
    }

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

    [ApiController]
    [Route("[controller]")]
    public class ParksController : ControllerBase
    {
        private static ReadOnlyDictionary<string, string> States = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
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

        private readonly ILogger<ParksController> _logger;
        private readonly NpsApiClient _npsApiClient;
        private readonly GeoLocationClient _geoApiClient;

        public ParksController(NpsApiClient npsApiClient, GeoLocationClient geoApiClient, ILogger<ParksController> logger)
        {
            _logger = logger;
            _npsApiClient = npsApiClient;
            _geoApiClient = geoApiClient;
        }

        [HttpGet(Name = "GetParks")]
        public async Task<IActionResult> Get(string city, string stateCode)
        {
            if(string.IsNullOrWhiteSpace(city))
            {
                return BadRequest("City is required.");
            }
            if (string.IsNullOrWhiteSpace(stateCode))
            {
                return BadRequest("State code is required.");
            }
            if (!States.TryGetValue(stateCode, out string stateName))
            {
                return BadRequest($"State is incorrect: {stateCode}");
            }

            try
            {
                // Getting city coordinates through geolocation API
                GeoCoordinate cityCoordinate;
                {
                    _logger.LogInformation($"Getting {city} coordinate...");

                    HttpResponseMessage cityLocationResponse = await _geoApiClient.GetCityLocation(city, CancellationToken.None);
                    if(!cityLocationResponse.IsSuccessStatusCode)
                    {
                        // TODO: We might want to add additional checking for other status codes like 429 for rate limiting
                        // Check status code and inform user. For simplicity, return 500 here
                        _logger.LogError($"Unable to get {city} location. Error while calling geolocation API: {cityLocationResponse.StatusCode}");
                        return StatusCode(500, "An error has occured"); // Calling external API has failed, nothing can be done.
                    }

                    // Parsing JSON response
                    string responseBody = await cityLocationResponse.Content.ReadAsStringAsync();
                    JsonDocument jd = JsonDocument.Parse(responseBody);
                    JsonElement root = jd.RootElement;
                    var cityElement = root.EnumerateArray()
                        .FirstOrDefault(x => x.GetProperty("name").GetString().Equals(city) && x.GetProperty("state").GetString().Equals(stateName));
                    if (cityElement.ValueKind == JsonValueKind.Undefined || cityElement.ValueKind == JsonValueKind.Null)
                    {
                        _logger.LogError($"{city}, {stateCode} wasn't found.");
                        return NotFound($"{city}, {stateCode} wasn't found.");
                    }

                    double latitude = cityElement.GetProperty("latitude").GetDouble();
                    double longitude = cityElement.GetProperty("longitude").GetDouble();

                    _logger.LogInformation($"{city} coordinate retrieved: {latitude},{longitude}");
                    cityCoordinate = new GeoCoordinate(latitude, longitude);
                }

                // Getting list of nearby national parks using NPS API
                {
                    _logger.LogInformation($"Getting {stateName} national parks...");

                    HttpResponseMessage parksResponse = await _npsApiClient.GetParks(stateCode, CancellationToken.None);
                    if (!parksResponse.IsSuccessStatusCode)
                    {
                        // TODO: We might want to add additional checking for other status codes like 429 for rate limiting
                        // Check status code and inform user. For simplicity, return 400 here
                        _logger.LogError($"Unable to parks list for {stateCode}. Error while calling NPS API: {parksResponse.StatusCode}");
                        return StatusCode(500, "An error has occured"); // Calling external API has failed, nothing can be done.
                    }

                    // Parsing JSON response
                    string responseBody = await parksResponse.Content.ReadAsStringAsync();
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

                    List<ParkData> result = parks
                        .OrderBy(x => x.distance)
                        .Take(3)
                        .ToList();

                    _logger.LogInformation("Park data retrieved succesfully");
                    return new ObjectResult(result) { StatusCode = 200, };
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occured.");
                return StatusCode(500, "An unexpected error occured."); // Calling external API has failed, nothing can be done.
            }
        }
    }
}
