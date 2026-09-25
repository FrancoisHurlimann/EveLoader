using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class TypeListFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("includedCategoryIDs")]
        public List<long> IncludedCategoryIDs { get; set; }

        [JsonPropertyName("includedGroupIDs")]
        public List<long> IncludedGroupIDs { get; set; }

        [JsonPropertyName("includedTypeIDs")]
        public List<long> IncludedTypeIDs { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
