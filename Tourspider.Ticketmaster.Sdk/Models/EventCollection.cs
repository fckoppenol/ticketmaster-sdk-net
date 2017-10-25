using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class EventCollection
    {
        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }


}
