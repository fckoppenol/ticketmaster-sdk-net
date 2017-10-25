using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class Response<T>
    {
        public Status Status { get; set; }

        public T Result { get; set; }
    }

    public class Status
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("errors")]
        public List<Error> Errors { get; set; } = new List<Error>();

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }

    public class Error
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
