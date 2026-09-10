using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class GraphicMaterialSet
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("colorHull")]
        public Color ColorHull { get; set; }

        [JsonPropertyName("colorPrimary")]
        public Color ColorPrimary { get; set; }

        [JsonPropertyName("colorSecondary")]
        public Color ColorSecondary { get; set; }

        [JsonPropertyName("colorWindow")]
        public Color ColorWindow { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("sofFactionName")]
        public string SofFactionName { get; set; }

        [JsonPropertyName("sofRaceHint")]
        public string SofRaceHint { get; set; }
    }

    public class Color
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("a")]
        public double A { get; set; }

        [JsonPropertyName("b")]
        public double B { get; set; }

        [JsonPropertyName("g")]
        public double G { get; set; }

        [JsonPropertyName("r")]
        public double R { get; set; }
    }
}
