using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class NpcStation
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("celestialIndex")]
        public long CelestialIndex { get; set; }

        [JsonPropertyName("operationID")]
        public long OperationID { get; set; }

        [JsonPropertyName("orbitID")]
        public long OrbitID { get; set; }

        [JsonPropertyName("orbitIndex")]
        public long? OrbitIndex { get; set; }

        [JsonPropertyName("ownerID")]
        public long OwnerID { get; set; }

        [JsonPropertyName("position")]
        public NpcStationPosition Position { get; set; }

        [JsonPropertyName("reprocessingEfficiency")]
        public double ReprocessingEfficiency { get; set; }

        [JsonPropertyName("reprocessingHangarFlag")]
        public long ReprocessingHangarFlag { get; set; }

        [JsonPropertyName("reprocessingStationsTake")]
        public double ReprocessingStationsTake { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }

        [JsonPropertyName("useOperationName")]
        public bool UseOperationName { get; set; }
    }

    public class NpcStationPosition
    {
        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("z")]
        public double Z { get; set; }
    }
}
