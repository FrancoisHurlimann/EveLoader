using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class Ancestry
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("bloodlineID")]
        public long BloodlineID { get; set; }

        [JsonPropertyName("charisma")]
        public long Charisma { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("iconID")]
        public long IconID { get; set; }

        [JsonPropertyName("intelligence")]
        public long Intelligence { get; set; }

        [JsonPropertyName("memory")]
        public long Memory { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("perception")]
        public long Perception { get; set; }

        [JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }

        [JsonPropertyName("willpower")]
        public long Willpower { get; set; }
    }
}
