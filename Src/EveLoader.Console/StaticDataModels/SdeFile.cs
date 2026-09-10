using System;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class SdeFile
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("buildNumber")]
        public long BuildNumber { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }
    }
}
