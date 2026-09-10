using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class TranslationLanguageFile
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
