
namespace AssessmentApp.API
{
    public interface IGeoLocationApiClient
    {
        Task<HttpResponseMessage> GetCityLocation(string cityName, CancellationToken cancellationToken);
    }
}