using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class TypeList
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
