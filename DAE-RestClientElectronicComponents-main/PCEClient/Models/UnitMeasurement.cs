using Newtonsoft.Json;

namespace PCEClient.Models
{
    public class UnitMeasurement
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
