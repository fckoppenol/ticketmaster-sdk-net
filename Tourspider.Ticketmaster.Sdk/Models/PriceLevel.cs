using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public  class PriceLevel
    {
        [JsonProperty("face_value")]
        public double FaceValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ticket_fees")]
        public double TicketFees { get; set; }
    }
}
