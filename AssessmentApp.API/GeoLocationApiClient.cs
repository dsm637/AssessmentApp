namespace AssessmentApp.API
{
    /// <summary>
    /// An Api Ninja wrapper class.
    /// </summary>
    public sealed class GeoLocationApiClient
    {
        private const string ApiKey = "kG3mOf7nK1Mxc3enWfRwHA==hhP3032rTRGKEQwl";
        private readonly HttpClient _httpClient;
        private readonly ILogger<GeoLocationApiClient> _logger;

        public GeoLocationApiClient(HttpClient httpClient, ILogger<GeoLocationApiClient> logger)
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
}
