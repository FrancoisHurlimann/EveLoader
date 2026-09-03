using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class DogmaUnit
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("displayName")]
        public Dictionary<string, string> DisplayName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
