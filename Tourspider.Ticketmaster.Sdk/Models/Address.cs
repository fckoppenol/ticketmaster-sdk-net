using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Address
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("address")]
        public string OtherAddress { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }
}
