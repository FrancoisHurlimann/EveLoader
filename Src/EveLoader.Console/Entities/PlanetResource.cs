using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class PlanetResource
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("power")]
        public long? Power { get; set; }

        [JsonPropertyName("workforce")]
        public long? Workforce { get; set; }
    }
}
