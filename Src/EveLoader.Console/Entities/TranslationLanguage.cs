using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class TranslationLanguage
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
