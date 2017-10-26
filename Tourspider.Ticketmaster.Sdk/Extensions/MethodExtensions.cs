using System.Collections.Generic;
using System.Threading.Tasks;
using Tourspider.Ticketmaster.Sdk.Methods.EventService;
using Tourspider.Ticketmaster.Sdk.Models;

namespace Tourspider.Ticketmaster.Sdk.Extensions
{
    public static class MethodExtensions
    {
        public static Response<EventCollection> EventSearch(this InternationalDiscoveryClient internationalDiscoveryClient, EventSearchArguments arguments)
        {
           return internationalDiscoveryClient.Query<EventSearch, EventCollection>(arguments);
        }

        public static Task<Response<EventCollection>> EventSearchAsync(this InternationalDiscoveryClient internationalDiscoveryClient, EventSearchArguments arguments)
        {
            return internationalDiscoveryClient.QueryAsync<EventSearch, EventCollection>(arguments);
        }

        public static Response<Event> EventDetails(this InternationalDiscoveryClient internationalDiscoveryClient, EventDetailsArguments arguments)
        {
            return internationalDiscoveryClient.Query<EventDetails, Event>(arguments);
        }

        public static Task<Response<Event>> EventDetailsAsync(this InternationalDiscoveryClient internationalDiscoveryClient, EventDetailsArguments arguments)
        {
            return internationalDiscoveryClient.QueryAsync<EventDetails, Event>(arguments);
        }
        
        public static Response<EventCollection> UpdatedEvents(this InternationalDiscoveryClient internationalDiscoveryClient, UpdatedEventsArguments arguments)
        {
            return internationalDiscoveryClient.Query<UpdatedEvents, EventCollection>(arguments);
        }

        public static Task<Response<EventCollection>> UpdatedEventsAsync(this InternationalDiscoveryClient internationalDiscoveryClient, UpdatedEventsArguments arguments)
        {
            return internationalDiscoveryClient.QueryAsync<UpdatedEvents, EventCollection>(arguments);
        }

        public static Response<EventEntity<PriceTypeCollection>> EventPrices(this InternationalDiscoveryClient internationalDiscoveryClient, EventPricesArguments arguments)
        {
            return internationalDiscoveryClient.Query<EventPrices, EventEntity<PriceTypeCollection>>(arguments);
        }

        public static Task<Response<EventEntity<PriceTypeCollection>>> EventPricesAsync(this InternationalDiscoveryClient internationalDiscoveryClient, EventPricesArguments arguments)
        {
            return internationalDiscoveryClient.QueryAsync<EventPrices, EventEntity<PriceTypeCollection>>(arguments);
        }

        ///// <summary>
        ///// Get a static map image of the venue for the event showing the location of seating or standing areas. 
        ///// Note that not all events will have a seatmap available - for example packages, festivals, many general admission music events, and so on. Interactive seatmaps are currently not available.
        ///// </summary>
        ///// <param name="internationalDiscoveryClient"></param>
        ///// <param name="arguments"></param>
        ///// <returns></returns>
        //public static Response<EventEntity> EventSeatmap(this InternationalDiscoveryClient internationalDiscoveryClient, EventSeatmapArguments arguments)
        //{
        //    return internationalDiscoveryClient.Query<EventSeatmap, EventEntity>(arguments);
        //}

        ///// <summary>
        ///// Get a static map image of the venue for the event showing the location of seating or standing areas. 
        ///// Note that not all events will have a seatmap available - for example packages, festivals, many general admission music events, and so on. Interactive seatmaps are currently not available.
        ///// </summary>
        ///// <param name="internationalDiscoveryClient"></param>
        ///// <param name="arguments"></param>
        ///// <returns></returns>
        //public static Task<Response<EventEntity>> EventSeatmapAsync(this InternationalDiscoveryClient internationalDiscoveryClient, EventSeatmapArguments arguments)
        //{
        //    return internationalDiscoveryClient.QueryAsync<EventSeatmap, EventEntity>(arguments);
        //}

        /// <summary>
        /// Get information on the seating areas available for an event and the prices for tickets.
        /// </summary>
        /// <param name="internationalDiscoveryClient"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static Response<EventEntity<EventArea>> EventAreas(this InternationalDiscoveryClient internationalDiscoveryClient, EventAreasArguments arguments)
        {
            return internationalDiscoveryClient.Query<EventAreas, EventEntity<EventArea>>(arguments);
        }

        /// <summary>
        /// Get information on the seating areas available for an event and the prices for tickets.
        /// </summary>
        /// <param name="internationalDiscoveryClient"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static Task<Response<EventEntity<EventArea>>> EventAreasAsync(this InternationalDiscoveryClient internationalDiscoveryClient, EventAreasArguments arguments)
        {
            return internationalDiscoveryClient.QueryAsync<EventAreas, EventEntity<EventArea>>(arguments);
        }

    }
}
