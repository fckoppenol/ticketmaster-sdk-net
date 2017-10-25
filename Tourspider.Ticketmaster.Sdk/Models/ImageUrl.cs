using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public  class ImageUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
