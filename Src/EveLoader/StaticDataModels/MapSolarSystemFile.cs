using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class MapSolarSystemFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("border")]
        public bool? Border { get; set; }

        [JsonPropertyName("constellationID")]
        public long ConstellationID { get; set; }

        [JsonPropertyName("corridor")]
        public bool? Corridor { get; set; }

        [JsonPropertyName("fringe")]
        public bool? Fringe { get; set; }

        [JsonPropertyName("hub")]
        public bool? Hub { get; set; }

        [JsonPropertyName("international")]
        public bool? International { get; set; }

        [JsonPropertyName("luminosity")]
        public double Luminosity { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("planetIDs")]
        public List<long> PlanetIDs { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("position2D")]
        public Position2D Position2D { get; set; }

        [JsonPropertyName("radius")]
        public double Radius { get; set; }

        [JsonPropertyName("regionID")]
        public long RegionID { get; set; }

        [JsonPropertyName("regional")]
        public bool? Regional { get; set; }

        [JsonPropertyName("securityClass")]
        public string SecurityClass { get; set; }

        [JsonPropertyName("securityStatus")]
        public double SecurityStatus { get; set; }

        [JsonPropertyName("starID")]
        public long StarID { get; set; }

        [JsonPropertyName("stargateIDs")]
        public List<long> StargateIDs { get; set; }
    }

    public class Position2D
    {
        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }
    }
}
