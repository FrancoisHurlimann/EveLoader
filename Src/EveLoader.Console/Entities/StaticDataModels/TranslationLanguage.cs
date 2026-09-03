using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class TranslationLanguage
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
