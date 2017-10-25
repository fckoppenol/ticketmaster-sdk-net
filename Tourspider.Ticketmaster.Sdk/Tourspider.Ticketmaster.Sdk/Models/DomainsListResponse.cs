using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TourSpider.Ticketmaster.Sdk.Models
{
    public class DomainsListResponse
    {

        [JsonProperty("domains")]
        public List<Domain> Domains { get; set; }

    }

    public class Domain
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("langs")]
        public List<Lang> Langs { get; set; }

        [JsonProperty("country_id")]
        public long CountryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("site_url")]
        public string SiteUrl { get; set; }
    }

    public partial class Lang
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
