﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
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
}
