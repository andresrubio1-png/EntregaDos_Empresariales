using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCEClient.Models
{
    public class PassiveComponentRequest
    {
        [JsonProperty("pinCount")]
        public int PinCount { get; set; }

        [JsonProperty("packageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PackageType PackageType { get; set; }

        [JsonProperty("voltage")]
        public double Voltage { get; set; }

        [JsonProperty("manufacturerId")]
        public int ManufacturerId { get; set; }

        [JsonProperty("tolerance")]
        public double Tolerance { get; set; }

        [JsonProperty("nominalValue")]
        public UnitMeasurement NominalValue { get; set; }
    }
}
