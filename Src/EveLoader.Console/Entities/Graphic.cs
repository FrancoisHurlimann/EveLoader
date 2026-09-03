using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class Graphic
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("graphicFile")]
        public string GraphicFile { get; set; }

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
