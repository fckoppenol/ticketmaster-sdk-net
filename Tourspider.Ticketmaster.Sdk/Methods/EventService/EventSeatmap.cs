using System;
using RestSharp;
using Tourspider.Ticketmaster.Sdk;
using Tourspider.Ticketmaster.Sdk.Extensions;
using Tourspider.Ticketmaster.Sdk.Interfaces;
using RestRequest = Tourspider.Ticketmaster.Sdk.RestRequest;

namespace Tourspider.Ticketmaster.Sdk.Methods.EventService
{
    public class EventSeatmap : Request
    {
        public override string Resource => "/event/{eventId}/seatmap";
    }
    public class EventSeatmapArguments : IRequestParameters
    {
        private readonly int _eventId;
        private readonly string _domainId;

        public EventSeatmapArguments(int eventId, string domainId)
        {
            if (string.IsNullOrEmpty(domainId))
                throw new ArgumentException("Invalid domainId");

            _eventId = eventId;
            _domainId = domainId;
        }

        public void AddToRequest(RestRequest restRequest)
        {
            restRequest.AddParameter("eventId", _eventId, ParameterType.UrlSegment);
            restRequest.AddQueryParameterIfNotEmpty("domain_id", _domainId);
        }
    }

}
