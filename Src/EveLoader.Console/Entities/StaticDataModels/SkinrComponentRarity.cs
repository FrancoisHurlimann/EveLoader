using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class SkinrComponentRarity
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("rank")]
        public long Rank { get; set; }
    }
}
