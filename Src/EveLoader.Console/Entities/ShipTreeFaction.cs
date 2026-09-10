using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class ShipTreeFaction
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("elements")]
        public List<ShipTreeFactionElement> Elements { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class ShipTreeFactionElement
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }
}
