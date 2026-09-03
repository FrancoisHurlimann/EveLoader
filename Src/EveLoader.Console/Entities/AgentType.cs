using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class AgentType
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
