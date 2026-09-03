using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class Dungeon
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("allowedShipsList")]
        public List<long> AllowedShipsList { get; set; }

        [JsonPropertyName("archetypeID")]
        public long ArchetypeID { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("factionID")]
        public long FactionID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }
    }
}
