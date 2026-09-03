using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class Icon
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("iconFile")]
        public string IconFile { get; set; }
    }
}
