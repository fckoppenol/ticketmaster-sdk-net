using RestSharp;
using RestSharp.Authenticators;

namespace Tourspider.Ticketmaster.Sdk
{
    internal class TicketmasterAuthenticator : IAuthenticator
    {
        private readonly string _apiKey;

        public TicketmasterAuthenticator(string apiKey)
        {
            _apiKey = apiKey;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddQueryParameter("apikey", _apiKey);
        }
    }
}