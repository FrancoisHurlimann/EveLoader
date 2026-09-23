using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class MercenaryTacticalOperation
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("anarchyImpact")]
        public long AnarchyImpact { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("developmentImpact")]
        public long DevelopmentImpact { get; set; }

        [JsonPropertyName("dungeonID")]
        public long DungeonID { get; set; }

        [JsonPropertyName("infomorphBonus")]
        public long InfomorphBonus { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
