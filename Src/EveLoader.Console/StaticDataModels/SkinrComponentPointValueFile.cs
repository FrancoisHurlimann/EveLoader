using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class SkinrComponentPointValueFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public List<SkinrComponentPointValueEntry> Value { get; set; }
    }

    public class SkinrComponentPointValueEntry
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }
}
