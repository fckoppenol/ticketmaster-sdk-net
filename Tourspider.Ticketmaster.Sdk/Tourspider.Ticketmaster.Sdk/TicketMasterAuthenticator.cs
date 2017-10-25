using RestSharp;
using RestSharp.Authenticators;

namespace TourSpider.Ticketmaster.Sdk
{
    internal class TicketMasterAuthenticator : IAuthenticator
    {
        private readonly string _apiKey;

        public TicketMasterAuthenticator(string apiKey)
        {
            _apiKey = apiKey;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddQueryParameter("apikey", _apiKey);
        }
    }
}