namespace AssessmentApp.API
{
    /// <summary>
    /// An Api Ninja wrapper class.
    /// </summary>
    public sealed class GeoLocationApiClient : IGeoLocationApiClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private readonly ILogger<GeoLocationApiClient> _logger;

        public GeoLocationApiClient(HttpClient httpClient, ILogger<GeoLocationApiClient> logger, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _apiKey = configuration.GetSection("AppSettings:ApiNinjaKey").Value;
        }

        public async Task<HttpResponseMessage> GetCityLocation(string cityName, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Calling Geo location API for {cityName}");
            string geoApiUrl = $"https://api.api-ninjas.com/v1/geocoding?city={cityName}&country=US";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, geoApiUrl);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("X-Api-Key", _apiKey);
            HttpResponseMessage response = await _httpClient.SendAsync(request, cancellationToken);

            return response;
        }
    }
}
