using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class MarketGroupFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("hasTypes")]
        public bool HasTypes { get; set; }

        [JsonPropertyName("iconID")]
        public long IconID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("parentGroupID")]
        public long? ParentGroupID { get; set; }
    }
}
