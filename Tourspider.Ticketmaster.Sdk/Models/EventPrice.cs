using System.Collections.Generic;
using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public class EventPrice
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("price_types")]
        public List<PriceType> PriceTypes { get; set; }
    }
}
