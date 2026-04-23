using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCEClient.Models
{
    public class PassiveComponent
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("pinCount")]
        public int PinCount { get; set; }

        [JsonProperty("packageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PackageType PackageType { get; set; }

        [JsonProperty("voltage")]
        public double Voltage { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("tolerance")]
        public double Tolerance { get; set; }

        [JsonProperty("nominalValue")]
        public UnitMeasurement NominalValue { get; set; }
    }
}
