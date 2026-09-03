using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class MapStargate
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("destination")]
        public StargateDestination Destination { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }

    public class StargateDestination
    {
        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("stargateID")]
        public long StargateID { get; set; }
    }
}
