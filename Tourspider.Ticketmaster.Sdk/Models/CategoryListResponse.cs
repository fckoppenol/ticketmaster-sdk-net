using System.Collections.Generic;
using Newtonsoft.Json;
using Tourspider.Ticketmaster.Sdk.Models;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class CategoryListResponse
    {
        [JsonProperty(PropertyName = "categories")]
        public List<Category> Categories { get; set; }
    }
}
