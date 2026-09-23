using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class ControlTowerResource
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("resources")]
        public List<ControlTowerResourceItem> Resources { get; set; }
    }

    public class ControlTowerResourceItem
    {
        [JsonPropertyName("purpose")]
        public long Purpose { get; set; }

        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        [JsonPropertyName("resourceTypeID")]
        public long ResourceTypeID { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }

        [JsonPropertyName("minSecurityLevel")]
        public double? MinSecurityLevel { get; set; }
    }
}
