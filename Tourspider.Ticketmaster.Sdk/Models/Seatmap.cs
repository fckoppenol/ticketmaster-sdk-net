using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public  class Seatmap
    {
        [JsonProperty("static")]
        public Static Static { get; set; }
    }
}
