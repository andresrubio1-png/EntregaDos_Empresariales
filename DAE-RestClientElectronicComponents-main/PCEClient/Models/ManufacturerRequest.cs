using Newtonsoft.Json;

namespace PCEClient.Models
{
    public class ManufacturerRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("averageLeadTime")]
        public double AverageLeadTime { get; set; }
    }
}
