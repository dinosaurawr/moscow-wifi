using RestSharp;
using RestSharp.Authenticators;

namespace MoscowWiFi.WebClient
{
    public class QueryParamsAuthenticator : IAuthenticator
    {
        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddQueryParameter("api_key", APISettings.APIKey);
        }
    }
}