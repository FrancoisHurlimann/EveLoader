using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class Type
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("basePrice")]
        public double? BasePrice { get; set; }

        [JsonPropertyName("capacity")]
        public double? Capacity { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("graphicID")]
        public long? GraphicID { get; set; }

        [JsonPropertyName("groupID")]
        public long GroupID { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("mass")]
        public double? Mass { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("portionSize")]
        public long PortionSize { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonPropertyName("raceID")]
        public long? RaceID { get; set; }

        [JsonPropertyName("radius")]
        public double? Radius { get; set; }

        [JsonPropertyName("soundID")]
        public long? SoundID { get; set; }

        [JsonPropertyName("volume")]
        public double? Volume { get; set; }
    }
}
