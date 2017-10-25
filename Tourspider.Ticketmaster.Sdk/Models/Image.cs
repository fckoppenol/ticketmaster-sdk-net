using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public  class Image
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }
}
