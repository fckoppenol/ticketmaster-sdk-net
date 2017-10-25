using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public class EventEntity<T>
    {
        [JsonProperty("event")]
        public T Event { get; set; }
    }
}
