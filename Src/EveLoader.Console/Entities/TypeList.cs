using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class TypeList
    {
        [Key]
        public int id { get; set; }

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
