using System;
using RestSharp;
using Tourspider.Ticketmaster.Sdk;
using Tourspider.Ticketmaster.Sdk.Extensions;
using Tourspider.Ticketmaster.Sdk.Interfaces;
using RestRequest = Tourspider.Ticketmaster.Sdk.RestRequest;

namespace Tourspider.Ticketmaster.Sdk.Methods.EventService
{
    /// <summary>
    /// Get details for a specific event using the unique identifer for the event. 
    /// This includes the venue and location, ticket availability and pricing, a description, and the Ticketmaster Website URL for purchasing tickets for the event.
    /// </summary>
    public class EventDetails : Request
    {
        public override string Resource => "/event/{eventId}";
    }
    public class EventDetailsArguments : IRequestParameters
    {
        /// <summary>
        /// A unique identifier for the event which is specific to the domain (e.g. Norway) Example: 449621.
        /// </summary>
        private readonly int _eventId;

        /// <summary>
        /// The unique identifier for the domain or market. Although optional, this is recommended. Example: norway.
        /// </summary>
        private readonly string _domainId;

        public EventDetailsArguments(int eventId, string domainId)
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

        public void AddToRequest(RestRequest restRequest)
        {
            restRequest.AddParameter("eventId", _eventId, ParameterType.UrlSegment);
            restRequest.AddQueryParameterIfNotEmpty("domain_id", _domainId);
            restRequest.AddQueryParameterIfNotEmpty("lang", Lang);
        }
    }

}
