using System;
using System.Collections.Generic;
using RestSharp;
using Tourspider.Ticketmaster.Sdk;
using Tourspider.Ticketmaster.Sdk.Extensions;
using Tourspider.Ticketmaster.Sdk.Interfaces;
using RestRequest = Tourspider.Ticketmaster.Sdk.RestRequest;

namespace Tourspider.Ticketmaster.Sdk.Methods.EventService
{
    public class EventPrices : Request
    {
        public override string Resource => "/event/{eventId}/prices";
    }
    public class EventPricesArguments : IRequestParameters
    {
        private readonly int _eventId;
        private readonly string _domainId;

        public EventPricesArguments(int eventId, string domainId)
        {
            if (string.IsNullOrEmpty(domainId))
                throw new ArgumentException("Invalid domainId");

            _eventId = eventId;
            _domainId = domainId;
        }

        /// <summary>
        /// The language in ISO code format. 
        /// The default language is specified in the Domains List service. Usually two or three languages are supported. Example: no-no.
        /// </summary>
        public string Lang { private get; set; }

        /// <summary>
        /// The unique identifier for the price level. 
        /// If no price level ID is specified, all applicable price levels for the event are returned. Example: 1,2.
        /// </summary>
        public List<int> PriceLevelIds { private get; set; } = new List<int>();

        public void AddToRequest(RestRequest restRequest)
        {
            restRequest.AddParameter("eventId", _eventId, ParameterType.UrlSegment);
            restRequest.AddQueryParameterIfNotEmpty("domain_id", _domainId);
            restRequest.AddQueryParameterIfNotEmpty("lang", Lang);
            restRequest.AddQueryParameterIfNotEmpty("price_level_ids", PriceLevelIds);
        }
    }

}
