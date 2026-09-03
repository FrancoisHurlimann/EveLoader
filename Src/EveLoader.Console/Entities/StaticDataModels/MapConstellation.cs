using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class MapConstellation
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("regionID")]
        public long RegionID { get; set; }

        [JsonPropertyName("solarSystemIDs")]
        public List<long> SolarSystemIDs { get; set; }

        [JsonPropertyName("wormholeClassID")]
        public long? WormholeClassID { get; set; }
    }
}
