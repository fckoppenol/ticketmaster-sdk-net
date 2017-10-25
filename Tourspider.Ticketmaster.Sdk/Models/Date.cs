using System;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public  class Eventdate
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("value")]
        public DateTime Value { get; set; }
    }
}
