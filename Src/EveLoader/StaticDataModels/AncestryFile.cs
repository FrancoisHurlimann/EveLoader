using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class AncestryFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("bloodlineID")]
        public long BloodlineID { get; set; }

        [JsonPropertyName("charisma")]
        public long Charisma { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public long IconID { get; set; }

        [JsonPropertyName("intelligence")]
        public long Intelligence { get; set; }

        [JsonPropertyName("memory")]
        public long Memory { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("perception")]
        public long Perception { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("willpower")]
        public long Willpower { get; set; }
    }
}
