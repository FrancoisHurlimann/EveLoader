using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class PlanetResource
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("power")]
        public long? Power { get; set; }

        [JsonPropertyName("workforce")]
        public long? Workforce { get; set; }
    }
}
