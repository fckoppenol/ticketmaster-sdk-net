using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Properties
    {
        [JsonProperty("package")]
        public bool Package { get; set; }

        [JsonProperty("seats_avail")]
        public bool SeatsAvail { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("rescheduled")]
        public bool Rescheduled { get; set; }

        [JsonProperty("sold_out")]
        public bool SoldOut { get; set; }




    }
}
