using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class MapRegion
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("constellationIDs")]
        public List<long> ConstellationIDs { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("nebulaID")]
        public long NebulaID { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("wormholeClassID")]
        public long? WormholeClassID { get; set; }
    }
}
