using System;
using RestSharp;
using TourSpider.Ticketmaster.Sdk;
using TourSpider.TicketMaster.Api.Extensions;
using TourSpider.TicketMaster.Api.Interfaces;
using RestRequest = TourSpider.Ticketmaster.Sdk.RestRequest;

namespace TourSpider.Ticketmaster.Sdk.Methods.EventService
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
