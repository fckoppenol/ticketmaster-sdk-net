using RestSharp;
using RestRequest = Tourspider.Ticketmaster.Sdk.RestRequest;

namespace Tourspider.Ticketmaster.Sdk.Methods
{
    public class DomainsListArguments
    {
        public int? CountryId { get; set; }

        public void BuildRestRequest(RestRequest restRequest)
        {
            if (CountryId != null)
            {
                restRequest.AddQueryParameter("country_id", CountryId.ToString());
            }


        }
    }
}
