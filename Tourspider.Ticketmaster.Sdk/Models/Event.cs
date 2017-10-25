using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Event
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("day_of_week")]
        public string DayOfWeek { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("attractions")]
        public List<Attraction> Attractions { get; set; } = new List<Attraction>();

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("eventdate")]
        public Eventdate Eventdate { get; set; }

        [JsonProperty("domain_id")]
        public string DomainId { get; set; }

        [JsonProperty("externalUrl")]
        public bool ExternalUrl { get; set; }

        [JsonProperty("offsale")]
        public Eventdate Offsale { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string>();

        [JsonProperty("localeventdate")]
        public string Localeventdate { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; } = new List<Image>();

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price_ranges")]
        public PriceRanges PriceRanges { get; set; }

        [JsonProperty("onsale")]
        public Eventdate Onsale { get; set; }


        [JsonProperty("promoter")]
        public Promoter Promoter { get; set; }

        [JsonProperty("seatmap_types")]
        public SeatmapTypes SeatmapTypes { get; set; }


        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }
    }

}
