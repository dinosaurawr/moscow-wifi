using RestSharp;

namespace MoscowWiFi.WebClient
{
    public static class ApiClient
    {
        public static readonly RestClient Client;
        static ApiClient()
        {
            Client = new RestClient(APISettings.BaseURL) {Authenticator = new QueryParamsAuthenticator()};
        }
    }
}