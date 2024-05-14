﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace AssessmentApp.API.Controllers
{
    public record ParkData(string Code, string Name, string Url, string Description, GeoCoordinate Location, double Distance);

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
        private readonly GeoLocationApiClient _geoApiClient;

        public ParksController(NpsApiClient npsApiClient, GeoLocationApiClient geoApiClient, ILogger<ParksController> logger)
        {
            _logger = logger;
            _npsApiClient = npsApiClient;
            _geoApiClient = geoApiClient;
        }

        [HttpGet(Name = "GetParks")]
        public async Task<IActionResult> Get(string city, string stateCode)
        {
            if (string.IsNullOrWhiteSpace(city))
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
                HttpResponseMessage cityLocationResponse = await _geoApiClient.GetCityLocation(city, CancellationToken.None);
                HttpResponseMessage parksResponse = await _npsApiClient.GetParks(stateCode, CancellationToken.None);

                GeoCoordinate cityCoordinate;
                {
                    _logger.LogInformation($"Getting {city} coordinate...");

                    if (!cityLocationResponse.IsSuccessStatusCode)
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
                        .OrderBy(x => x.Distance)
                        .Take(3)
                        .ToList();

                    _logger.LogInformation("Park data retrieved succesfully");
                    return new ObjectResult(result) { StatusCode = 200, };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occured.");
                return StatusCode(500, "An unexpected error occured."); // Calling external API has failed, nothing can be done.
            }
        }
    }
}