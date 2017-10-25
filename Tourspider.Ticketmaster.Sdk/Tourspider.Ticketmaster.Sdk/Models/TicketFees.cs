using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public class TicketFees
    {
        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }
    }
}
