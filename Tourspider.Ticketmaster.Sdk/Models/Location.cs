using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public class Location
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
