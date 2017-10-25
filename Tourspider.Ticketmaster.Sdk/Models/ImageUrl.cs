using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public  class ImageUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
