using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class EventEntity<T>
    {
        [JsonProperty("event")]
        public T Event { get; set; }
    }

    public class EventProperties
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }


    }

    //TODO: Collection
    public class PriceTypeCollection : EventProperties
    {
        [JsonProperty("price_types")]
        public List<PriceType> PriceTypes { get; set; }
    }
}
