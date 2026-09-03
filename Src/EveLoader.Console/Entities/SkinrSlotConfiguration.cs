using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class SkinrSlotConfiguration
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("allowAllShips")]
        public bool? AllowAllShips { get; set; }

        [JsonPropertyName("config")]
        public List<long> Config { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("priority")]
        public long Priority { get; set; }

        [JsonPropertyName("ships")]
        public List<long> Ships { get; set; }
    }
}
