using Microsoft.Extensions.Configuration;

namespace AssessmentApp.API
{
    /// <summary>
    /// A National Park System Api wrapper class.
    /// </summary>
    public sealed class NpsApiClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private readonly ILogger<NpsApiClient> _logger;

        public NpsApiClient(HttpClient httpClient, ILogger<NpsApiClient> logger, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _apiKey = configuration.GetSection("AppSettings:NpsApiKey").Value;
        }

        public async Task<HttpResponseMessage> GetParks(string stateCode, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Calling NPS API for {stateCode}");
            string parksUrl = $"https://developer.nps.gov/api/v1/parks?stateCode={stateCode}";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, parksUrl);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("X-Api-Key", _apiKey);
            HttpResponseMessage response = await _httpClient.SendAsync(request, cancellationToken);

            return response;
        }
    }
}
