using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class Sde
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("buildNumber")]
        public long BuildNumber { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }
    }
}
