using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Subcategory
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
