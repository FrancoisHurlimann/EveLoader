using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class MetaGroupFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("color")]
        public ColorRGB Color { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("iconSuffix")]
        public string IconSuffix { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }
    }

    public class ColorRGB
    {
        [JsonPropertyName("r")]
        public double R { get; set; }

        [JsonPropertyName("g")]
        public double G { get; set; }

        [JsonPropertyName("b")]
        public double B { get; set; }
    }
}
