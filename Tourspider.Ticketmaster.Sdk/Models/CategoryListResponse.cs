using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class CategoryListResponse
    {

        [JsonProperty(PropertyName = "categories")]
        public List<Category> Categories { get; set; }

    }

    public  class Category
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "subcategories")]
        public List<Subcategory> Subcategories { get; set; }
    }

    public  class Subcategory
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


    }
}
