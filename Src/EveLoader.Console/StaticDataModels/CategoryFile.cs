using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class CategoryFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }
    }
}
