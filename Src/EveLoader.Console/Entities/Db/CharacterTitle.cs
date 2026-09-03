using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class CharacterTitle
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }
    }
}
