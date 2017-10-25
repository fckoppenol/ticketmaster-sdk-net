using TourSpider.Ticketmaster.Sdk;

namespace TourSpider.Ticketmaster.Sdk.Interfaces
{
    public interface IRequestParameters
    {
         void AddToRequest(RestRequest restRequest);
    }
}
