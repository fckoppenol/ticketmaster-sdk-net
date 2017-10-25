using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public partial class Static
    {
        [JsonProperty("images")]
        public List<ImageUrl> Images { get; set; }
    }
}
