using System.Collections.Generic;
using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public class EventArea
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("areas")]
        public List<Area> Areas { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
