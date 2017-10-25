using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public partial class Attraction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
