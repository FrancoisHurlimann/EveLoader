using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class MapMoon
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("attributes")]
        public PlanetAttributes Attributes { get; set; }

        [JsonPropertyName("celestialIndex")]
        public long CelestialIndex { get; set; }

        [JsonPropertyName("orbitID")]
        public long OrbitID { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("radius")]
        public double Radius { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("statistics")]
        public CelestialStatistics Statistics { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
