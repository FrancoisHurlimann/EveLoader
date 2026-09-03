using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class MapStar
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("radius")]
        public long Radius { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("statistics")]
        public StarStatistics Statistics { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }

    public class StarStatistics
    {
        [JsonPropertyName("age")]
        public double Age { get; set; }

        [JsonPropertyName("life")]
        public double Life { get; set; }

        [JsonPropertyName("luminosity")]
        public double Luminosity { get; set; }

        [JsonPropertyName("spectralClass")]
        public string SpectralClass { get; set; }

        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }
    }
}
