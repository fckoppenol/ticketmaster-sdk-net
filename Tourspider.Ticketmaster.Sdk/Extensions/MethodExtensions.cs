using System.Threading.Tasks;

using Tourspider.Ticketmaster.Sdk.Methods.EventService;
using Tourspider.Ticketmaster.Sdk.Methods.EventService;
using Tourspider.Ticketmaster.Sdk.Models;
using TourSpider.Ticketmaster.Sdk.Models;

namespace Tourspider.Ticketmaster.Sdk.Extensions
{
    public static class MethodExtensions
    {
        public static Response<EventCollection> EventSearch(this DiscoveryClient discoveryClient, EventSearchArguments arguments)
        {
           return discoveryClient.Query<EventSearch, EventCollection>(arguments);
        }

        public static Task<Response<EventCollection>> EventSearchAsync(this DiscoveryClient discoveryClient, EventSearchArguments arguments)
        {
            return discoveryClient.QueryAsync<EventSearch, EventCollection>(arguments);
        }

        public static Response<Event> EventDetails(this DiscoveryClient discoveryClient, EventDetailsArguments arguments)
        {
            return discoveryClient.Query<EventDetails, Event>(arguments);
        }

        public static Task<Response<EventDetailsResponse>> EventDetailsAsync(this DiscoveryClient discoveryClient, EventDetailsArguments arguments)
        {
            return discoveryClient.QueryAsync<EventDetails, EventDetailsResponse>(arguments);
        }
        
        public static Response<EventCollection> UpdatedEvents(this DiscoveryClient discoveryClient, UpdatedEventsArguments arguments)
        {
            return discoveryClient.Query<UpdatedEvents, EventCollection>(arguments);
        }

        public static Task<Response<EventCollection>> UpdatedEventsAsync(this DiscoveryClient discoveryClient, UpdatedEventsArguments arguments)
        {
            return discoveryClient.QueryAsync<UpdatedEvents, EventCollection>(arguments);
        }

        public static Response<EventEntity<Seatmap>> EventPrices(this DiscoveryClient discoveryClient, EventPricesArguments arguments)
        {
            return discoveryClient.Query<EventPrices, EventEntity<Seatmap>>(arguments);
        }

        public static Task<Response<EventEntity<Seatmap>>> EventPricesAsync(this DiscoveryClient discoveryClient, EventPricesArguments arguments)
        {
            return discoveryClient.QueryAsync<EventPrices, EventEntity<Seatmap>>(arguments);
        }

        ///// <summary>
        ///// Get a static map image of the venue for the event showing the location of seating or standing areas. 
        ///// Note that not all events will have a seatmap available - for example packages, festivals, many general admission music events, and so on. Interactive seatmaps are currently not available.
        ///// </summary>
        ///// <param name="discoveryClient"></param>
        ///// <param name="arguments"></param>
        ///// <returns></returns>
        //public static Response<EventEntity> EventSeatmap(this DiscoveryClient discoveryClient, EventSeatmapArguments arguments)
        //{
        //    return discoveryClient.Query<EventSeatmap, EventEntity>(arguments);
        //}

        ///// <summary>
        ///// Get a static map image of the venue for the event showing the location of seating or standing areas. 
        ///// Note that not all events will have a seatmap available - for example packages, festivals, many general admission music events, and so on. Interactive seatmaps are currently not available.
        ///// </summary>
        ///// <param name="discoveryClient"></param>
        ///// <param name="arguments"></param>
        ///// <returns></returns>
        //public static Task<Response<EventEntity>> EventSeatmapAsync(this DiscoveryClient discoveryClient, EventSeatmapArguments arguments)
        //{
        //    return discoveryClient.QueryAsync<EventSeatmap, EventEntity>(arguments);
        //}

        /// <summary>
        /// Get information on the seating areas available for an event and the prices for tickets.
        /// </summary>
        /// <param name="discoveryClient"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static Response<EventEntity<EventArea>> EventAreas(this DiscoveryClient discoveryClient, EventAreasArguments arguments)
        {
            return discoveryClient.Query<EventAreas, EventEntity<EventArea>>(arguments);
        }

        /// <summary>
        /// Get information on the seating areas available for an event and the prices for tickets.
        /// </summary>
        /// <param name="discoveryClient"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static Task<Response<EventEntity<EventArea>>> EventAreasAsync(this DiscoveryClient discoveryClient, EventAreasArguments arguments)
        {
            return discoveryClient.QueryAsync<EventAreas, EventEntity<EventArea>>(arguments);
        }

    }
}
