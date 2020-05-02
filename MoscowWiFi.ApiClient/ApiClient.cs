using RestSharp;

namespace MoscowWiFi.WebClient
{
    public static class APIClient
    {
        public static readonly RestClient Client;
        static APIClient()
        {
            Client = new RestClient(APISettings.BaseURL) {Authenticator = new QueryParamsAuthenticator()};
        }
    }
}