using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public  class Seatmap
    {
        [JsonProperty("static")]
        public Static Static { get; set; }
    }
}
