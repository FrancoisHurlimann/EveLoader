using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class MapAsteroidBelt
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("celestialIndex")]
        public long CelestialIndex { get; set; }

        [JsonPropertyName("orbitID")]
        public long OrbitID { get; set; }

        [JsonPropertyName("orbitIndex")]
        public long OrbitIndex { get; set; }

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

    public class CelestialStatistics
    {
        [JsonPropertyName("density")]
        public double Density { get; set; }

        [JsonPropertyName("eccentricity")]
        public double Eccentricity { get; set; }

        [JsonPropertyName("escapeVelocity")]
        public double EscapeVelocity { get; set; }

        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        [JsonPropertyName("massDust")]
        public double MassDust { get; set; }

        [JsonPropertyName("massGas")]
        public double MassGas { get; set; }

        [JsonPropertyName("orbitPeriod")]
        public double OrbitPeriod { get; set; }

        [JsonPropertyName("orbitRadius")]
        public double OrbitRadius { get; set; }

        [JsonPropertyName("pressure")]
        public double? Pressure { get; set; }

        [JsonPropertyName("rotationRate")]
        public double RotationRate { get; set; }

        [JsonPropertyName("spectralClass")]
        public string SpectralClass { get; set; }

        [JsonPropertyName("surfaceGravity")]
        public double SurfaceGravity { get; set; }

        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }
    }
}
