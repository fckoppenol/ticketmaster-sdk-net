using RestSharp;
using RestRequest = TourSpider.Ticketmaster.Sdk.RestRequest;

namespace TourSpider.Ticketmaster.Sdk.Methods
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
