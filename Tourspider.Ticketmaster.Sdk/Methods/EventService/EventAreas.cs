using System;
using System.Globalization;
using RestSharp;
using Tourspider.Ticketmaster.Sdk.Extensions;
using Tourspider.Ticketmaster.Sdk.Interfaces;


namespace Tourspider.Ticketmaster.Sdk.Methods.EventService
{
    public class EventAreas : Request
    {
        public override string Resource => "/event/{eventId}/areas";
    }
    public class EventAreasArguments : IRequestParameters
    {
        /// <summary>
        /// A unique identifier for the event which is specific to the domain. Example: 449621.
        /// </summary>
        private readonly int _eventId;

        /// <summary>
        /// The unique identifier for the domain or market. Although optional, this is recommended. Example: norway.
        /// </summary>
        private readonly string _domainId;

        public EventAreasArguments(int eventId, string domainId)
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
        public CultureInfo Lang { private get; set; }

        public void AddToRequest(RestRequest restRequest)
        {
            restRequest.AddParameter("eventId", _eventId, ParameterType.UrlSegment);
            restRequest.AddQueryParameterIfNotEmpty("domain_id", _domainId);
            restRequest.AddQueryParameterIfNotEmpty("lang", Lang);
        }
    }

}
