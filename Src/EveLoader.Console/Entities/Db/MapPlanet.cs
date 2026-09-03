using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class MapPlanet
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("asteroidBeltIDs")]
        public List<long> AsteroidBeltIDs { get; set; }

        [JsonPropertyName("attributes")]
        public PlanetAttributes Attributes { get; set; }

        [JsonPropertyName("celestialIndex")]
        public long CelestialIndex { get; set; }

        [JsonPropertyName("moonIDs")]
        public List<long> MoonIDs { get; set; }

        [JsonPropertyName("npcStationIDs")]
        public List<long> NpcStationIDs { get; set; }

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

    public class PlanetAttributes
    {
        [JsonPropertyName("heightMap1")]
        public long HeightMap1 { get; set; }

        [JsonPropertyName("heightMap2")]
        public long HeightMap2 { get; set; }

        [JsonPropertyName("population")]
        public bool Population { get; set; }

        [JsonPropertyName("shaderPreset")]
        public long ShaderPreset { get; set; }
    }
}
