using System;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class Sde
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("buildNumber")]
        public long BuildNumber { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }
    }
}
