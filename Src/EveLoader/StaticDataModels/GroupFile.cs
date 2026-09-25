using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class GroupFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("anchorable")]
        public bool Anchorable { get; set; }

        [JsonPropertyName("anchored")]
        public bool Anchored { get; set; }

        [JsonPropertyName("categoryID")]
        public long CategoryID { get; set; }

        [JsonPropertyName("fittableNonSingleton")]
        public bool FittableNonSingleton { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonPropertyName("useBasePrice")]
        public bool UseBasePrice { get; set; }
    }
}
