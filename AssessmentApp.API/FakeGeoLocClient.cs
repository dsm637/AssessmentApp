
namespace AssessmentApp.API
{
    internal sealed class FakeGeoLocClient : IGeoLocationApiClient
    {
        private const string JsonResponse = @"[
  {
    ""name"": ""Waltham"",
    ""latitude"": 42.3756401,
    ""longitude"": -71.2358004,
    ""country"": ""US"",
    ""state"": ""Massachusetts""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 44.12589065,
    ""longitude"": -73.23344498851795,
    ""country"": ""US"",
    ""state"": ""Vermont""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 44.7092404,
    ""longitude"": -68.3383535,
    ""country"": ""US"",
    ""state"": ""Maine""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 43.8216451,
    ""longitude"": -92.8771918,
    ""country"": ""US"",
    ""state"": ""Minnesota""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 41.4331802,
    ""longitude"": -89.0103533,
    ""country"": ""US"",
    ""state"": ""Illinois""
  }
]";
        public Task<HttpResponseMessage> GetCityLocation(string cityName, CancellationToken cancellationToken)
        {
            var jsonContent = new StringContent(JsonResponse);
            HttpResponseMessage result = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = jsonContent,
            };

            return Task.FromResult(result);
        }
    }
}
