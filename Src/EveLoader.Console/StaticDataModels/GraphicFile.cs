using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class GraphicFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("graphicFile")]
        public string GraphicFileName { get; set; }

        [JsonPropertyName("iconFolder")]
        public string IconFolder { get; set; }

        [JsonPropertyName("sofFactionName")]
        public string SofFactionName { get; set; }

        [JsonPropertyName("sofHullName")]
        public string SofHullName { get; set; }

        [JsonPropertyName("sofRaceName")]
        public string SofRaceName { get; set; }
    }
}
