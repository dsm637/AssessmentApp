﻿namespace AssessmentApp.API
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
}
