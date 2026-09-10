using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class SkinrComponentCategory
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
