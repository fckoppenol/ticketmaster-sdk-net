using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Venue
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
