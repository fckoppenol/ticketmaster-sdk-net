using System.Collections.Generic;
using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public  class PriceType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("price_levels")]
        public List<PriceLevel> PriceLevels { get; set; }

        [JsonProperty("regular")]
        public bool Regular { get; set; }
    }
}
