using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class TypeElement
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("elements")]
        public List<TypeElementEntry> Elements { get; set; }
    }

    public class TypeElementEntry
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }
}
