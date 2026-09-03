using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class Dungeon
    {
        [Key]
        public int id { get; set; }

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
