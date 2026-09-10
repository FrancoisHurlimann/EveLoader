using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class IconFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("iconFile")]
        public string IconFileName { get; set; }
    }
}
