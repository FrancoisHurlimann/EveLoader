using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class SkinMaterialFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("displayName")]
        public Dictionary<string, string> DisplayName { get; set; }

        [JsonPropertyName("materialSetID")]
        public long MaterialSetID { get; set; }
    }
}
