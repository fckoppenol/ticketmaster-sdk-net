using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public  class SeatmapTypes
    {
        [JsonProperty("interactive_overview")]
        public bool InteractiveOverview { get; set; }

        [JsonProperty("interactive_detailed")]
        public bool InteractiveDetailed { get; set; }

        [JsonProperty("static")]
        public bool Static { get; set; }
    }
}
