using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class SkinrTierThreshold
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public List<SkinrTierThresholdEntry> Value { get; set; }
    }

    public class SkinrTierThresholdEntry
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }
}
