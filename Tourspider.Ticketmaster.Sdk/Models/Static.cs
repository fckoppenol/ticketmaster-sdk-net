using System.Collections.Generic;
using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public partial class Static
    {
        [JsonProperty("images")]
        public List<ImageUrl> Images { get; set; }
    }
}
