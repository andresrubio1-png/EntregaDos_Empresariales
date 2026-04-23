using System;
using Newtonsoft.Json;

namespace PCEClient.Models
{
    public class Manufacturer
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("averageLeadTime")]
        public double AverageLeadTime { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        public override string ToString() => $"{Name} ({Country})";
    }
}
