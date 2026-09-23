using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
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
        public string Description { get; set; }

        [JsonPropertyName("factionID")]
        public long FactionID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
