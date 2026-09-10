using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class SkinrSlot
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("allowedDesignComponentCategories")]
        public List<long> AllowedDesignComponentCategories { get; set; }

        [JsonPropertyName("category")]
        public long Category { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
