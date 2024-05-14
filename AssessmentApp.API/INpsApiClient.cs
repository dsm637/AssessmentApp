
namespace AssessmentApp.API
{
    public interface INpsApiClient
    {
        Task<HttpResponseMessage> GetParks(string stateCode, CancellationToken cancellationToken);
    }
}