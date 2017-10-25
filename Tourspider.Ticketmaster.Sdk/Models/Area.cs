using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Area
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("price_level_ids")]
        public List<long> PriceLevelIds { get; set; }

        [JsonProperty("price_ranges")]
        public PriceRanges PriceRanges { get; set; }
    }
}
