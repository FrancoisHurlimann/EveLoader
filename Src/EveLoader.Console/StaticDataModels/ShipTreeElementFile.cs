using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class ShipTreeElementFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }
    }
}
