using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class EventEntity<T>
    {
        [JsonProperty("event")]
        public T Event { get; set; }
    }
}
