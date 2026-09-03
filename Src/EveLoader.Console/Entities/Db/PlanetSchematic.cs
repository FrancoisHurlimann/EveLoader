using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class PlanetSchematic
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("cycleTime")]
        public long CycleTime { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

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
