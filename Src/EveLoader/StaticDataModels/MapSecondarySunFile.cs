using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class MapSecondarySunFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("effectBeaconTypeID")]
        public long EffectBeaconTypeID { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
