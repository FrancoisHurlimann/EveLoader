using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class PlanetSchematic
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("cycleTime")]
        public long CycleTime { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("pins")]
        public List<long> Pins { get; set; }

        [JsonPropertyName("types")]
        public List<PlanetSchematicType> Types { get; set; }
    }

    public class PlanetSchematicType
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("isInput")]
        public bool IsInput { get; set; }

        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
