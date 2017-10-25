using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Promoter
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
