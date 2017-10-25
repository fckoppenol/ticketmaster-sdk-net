using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Location
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
