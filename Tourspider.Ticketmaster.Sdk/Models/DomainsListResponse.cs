using System.Collections.Generic;
using Newtonsoft.Json;
using Tourspider.Ticketmaster.Sdk.Models;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class DomainsListResponse
    {
        [JsonProperty("domains")]
        public List<Domain> Domains { get; set; }

    }
}
