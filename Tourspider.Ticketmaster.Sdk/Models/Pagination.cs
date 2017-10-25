using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Pagination
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("rows")]
        public long Rows { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

}
