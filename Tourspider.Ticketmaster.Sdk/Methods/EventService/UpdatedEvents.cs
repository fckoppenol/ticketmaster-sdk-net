using System;
using Tourspider.Ticketmaster.Sdk;
using Tourspider.Ticketmaster.Sdk.Extensions;
using Tourspider.Ticketmaster.Sdk.Interfaces;

namespace Tourspider.Ticketmaster.Sdk.Methods.EventService
{
    public class UpdatedEvents : Request
    {
        public override string Resource => "/event/updated";
    }
    public class UpdatedEventsArguments : IRequestParameters
    {
        private readonly DateTime _updatedSince;
        private readonly string _domainId;

        public UpdatedEventsArguments(DateTime updatedSince, string domainId)
        {
            if (string.IsNullOrEmpty(domainId))
                throw new ArgumentException("Invalid domainId");

            _updatedSince = updatedSince;
            _domainId = domainId;
        }

        /// <summary>
        /// The language in ISO code format. 
        /// The default language is specified in the Domains List service. Usually two or three languages are supported. Example: no-no.
        /// </summary>
        public string Lang { private get; set; }


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

        public void AddToRequest(RestRequest restRequest)
        {
            restRequest.AddQueryParameterIfNotEmpty("updated_since", _updatedSince);
            restRequest.AddQueryParameterIfNotEmpty("domain_id", _domainId);
            restRequest.AddQueryParameterIfNotEmpty("lang", Lang);
            restRequest.AddQueryParameterIfNotEmpty("rows", _rows);
        }
    }

}
