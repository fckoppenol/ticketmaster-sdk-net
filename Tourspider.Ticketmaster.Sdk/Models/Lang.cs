using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Lang
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
