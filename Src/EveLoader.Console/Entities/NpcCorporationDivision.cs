using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class NpcCorporationDivision
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("internalName")]
        public string InternalName { get; set; }

        [JsonPropertyName("leaderTypeName")]
        public string LeaderTypeName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
