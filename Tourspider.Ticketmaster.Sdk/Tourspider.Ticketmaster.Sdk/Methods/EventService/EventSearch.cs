﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TourSpider.Ticketmaster.Sdk;
using TourSpider.TicketMaster.Api.Extensions;
using TourSpider.TicketMaster.Api.Interfaces;

namespace TourSpider.Ticketmaster.Sdk.Methods.EventService
{
    /// <summary>
    /// Find events and filter your search by event type, location, date, availability, and much more.
    /// </summary>
    public class EventSearch : Request
    {
        public override string Resource => "/events";
    }

    public class EventSearchArguments : IRequestParameters
    {
        public enum SortOptions
        {
            [EnumMember(Value = "eventname")]
            EventName,
            [EnumMember(Value = "popularity")]
            Popularity,
            [EnumMember(Value = "eventdate")]
            EventDate,
            [EnumMember(Value = "proximity")]
            Proximity
        }

        public enum OrderOptions
        {
            [EnumMember(Value = "asc")]
            Ascending,
            [EnumMember(Value = "desc")]
            Descending
        }

        /// <summary>
        /// The unique identifier for the domain or market. 
        /// Although optional, this is recommended. Use a comma separated list of values to search multiple domains. (A logical OR search is performed).
        /// </summary>
        public List<string> DomainIds { private get; set; } = new List<string>();

        /// <summary>
        /// The language in ISO code format. The default language is specified in the Domains List service. Usually two or three languages are supported. Example: no-no.
        /// </summary>
        public string Lang { private get; set; }

        /// <summary>
        /// The unique identifier for the attraction (which could be an artist, or sport, tour, package, play and so on). This is linked to domain. 
        /// Use a comma separated list of values to search for multiple events. (A logical OR search is performed). Example: 453127.
        /// </summary>
        public List<string> EventIds { private get; set; } = new List<string>();

        /// <summary>
        /// The unique identifier for the attraction (which could be an artist, package, play and so on). This is linked to domain. 
        /// Use a comma separated list of values to search for multiple attractions. (A logical OR search is performed). Example: 709593.
        /// </summary>
        public List<string> AttractionIds { private get; set; } = new List<string>();

        /// <summary>
        /// A unique identifer for the major category of an event. For example, 10001 is for ‘Music’. A list of category IDs and names is available in the Category List service. 
        /// Use a comma separated list of values to search for multiple categories. (A logical OR search is performed). Example: 10001.
        /// </summary>
        public List<int> CategoryIds { private get; set; } = new List<int>();

        /// <summary>
        /// A unique identifier for the subcategory of an event. For example, 1 is for ‘Rock/Pop’. A list of category IDs and names is available in the Category List service. 
        /// Use a comma separated list of values to search for multiple subcategories. (A logical OR search is performed). Example: 1.
        /// </summary>
        public List<int> SubCategoryIds { private get; set; } = new List<int>();

        /// <summary>
        /// The name of the event. Example: 50.
        /// </summary>
        public string EventName { private get; set; }

        public double? Latitude { private get; set; }

        public double? Longitude { private get; set; }

        public int? RadiusInKm { private get; set; }

        public DateTime? EventDateFrom { private get; set; }

        public DateTime? EventDateTo { private get; set; }

        public DateTime? OnSaleDateFrom { private get; set; }

        public DateTime? OnSaleDateTo { private get; set; }

        public bool? IncludeExternalEvents { private get; set; }

        /// <summary>
        /// A flag which when set to ‘true’ gives only events which still have tickets available on sale.
        /// </summary>
        public bool? IsSeatsAvailable { private get; set; } = true;

        public int? CountryId { private get; set; }

        /// <summary>
        /// The method for sorting the results. Proximity can only be used where a lat and long is used as a query parameter. 
        /// Default: eventdate. Possible values: eventdate , eventname , popularity , proximity .
        /// </summary>
        public SortOptions SortBy { private get; set; } = SortOptions.EventDate;

        /// <summary>
        /// The order in which results are sorted, whether ascending or descending. Default: asc. Possible values: asc , desc 
        /// </summary>
        public OrderOptions Order { private get; set; } = OrderOptions.Ascending;

        private int _rows = 10;
        /// <summary>
        /// The number of rows to return, up to a maximum of 250. Default: 10.
        /// </summary>
        public int Rows
        {
            set
            {
                if (value > 250 || value <= 0)
                    throw new Exception("Invalid Rows parameter");

                _rows = value;
            }
        }

        private int _start;
        /// <summary>
        /// The offset for pagination which specifies the start row to return. Default: 0.
        /// </summary>
        public int Start
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Start parameter");

                _start = value;
            }
        }

        public void AddToRequest(RestRequest restRequest)
        {
            restRequest.AddQueryParameterIfNotEmpty("domain_ids", DomainIds);
            restRequest.AddQueryParameterIfNotEmpty("lang", Lang);
            restRequest.AddQueryParameterIfNotEmpty("event_id", EventIds);
            restRequest.AddQueryParameterIfNotEmpty("attraction_ids", AttractionIds);
            restRequest.AddQueryParameterIfNotEmpty("category_ids", CategoryIds);
            restRequest.AddQueryParameterIfNotEmpty("subcategory_ids", SubCategoryIds);
            restRequest.AddQueryParameterIfNotEmpty("event_name", EventName);
            restRequest.AddQueryParameterIfNotEmpty("lat", Latitude);
            restRequest.AddQueryParameterIfNotEmpty("long", Longitude);
            restRequest.AddQueryParameterIfNotEmpty("radius", RadiusInKm);
            restRequest.AddQueryParameterIfNotEmpty("eventdate_from", EventDateFrom);
            restRequest.AddQueryParameterIfNotEmpty("eventdate_to", EventDateTo);
            restRequest.AddQueryParameterIfNotEmpty("onsaledate_from", OnSaleDateFrom);
            restRequest.AddQueryParameterIfNotEmpty("onsaledate_to", OnSaleDateTo);
            restRequest.AddQueryParameterIfNotEmpty("is_seats_available", IsSeatsAvailable);
            restRequest.AddQueryParameterIfNotEmpty("include_external_events", IncludeExternalEvents);
            restRequest.AddQueryParameterIfNotEmpty("country_id", CountryId);
            restRequest.AddQueryParameterIfNotEmpty("sort_by", SortBy.GetValue());
            restRequest.AddQueryParameterIfNotEmpty("order", Order.GetValue());
            restRequest.AddQueryParameterIfNotEmpty("start", _start);
            restRequest.AddQueryParameterIfNotEmpty("rows", _rows);
        }
    }

}
