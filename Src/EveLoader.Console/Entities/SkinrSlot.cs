using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class SkinrSlot
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("allowedDesignComponentCategories")]
        public List<long> AllowedDesignComponentCategories { get; set; }

        [JsonPropertyName("category")]
        public long Category { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }
    }
}
