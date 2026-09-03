using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class Blueprint
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("activities")]
        public BlueprintActivities Activities { get; set; }

        [JsonPropertyName("blueprintTypeID")]
        public long BlueprintTypeID { get; set; }

        [JsonPropertyName("maxProductionLimit")]
        public long MaxProductionLimit { get; set; }
    }

    public class BlueprintActivities
    {
        [JsonPropertyName("copying")]
        public BlueprintActivity Copying { get; set; }

        [JsonPropertyName("manufacturing")]
        public BlueprintManufacturing Manufacturing { get; set; }

        [JsonPropertyName("invention")]
        public BlueprintInvention Invention { get; set; }

        [JsonPropertyName("research_material")]
        public BlueprintActivity ResearchMaterial { get; set; }

        [JsonPropertyName("research_time")]
        public BlueprintActivity ResearchTime { get; set; }
    }

    public class BlueprintActivity
    {
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }

    public class BlueprintManufacturing : BlueprintActivity
    {
        [JsonPropertyName("materials")]
        public List<BlueprintMaterial> Materials { get; set; }

        [JsonPropertyName("products")]
        public List<BlueprintProduct> Products { get; set; }

        [JsonPropertyName("skills")]
        public List<BlueprintSkill> Skills { get; set; }
    }

    public class BlueprintInvention : BlueprintManufacturing
    {
    }

    public class BlueprintMaterial
    {
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }

    public class BlueprintProduct
    {
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }

        [JsonPropertyName("probability")]
        public double? Probability { get; set; }
    }

    public class BlueprintSkill
    {
        [JsonPropertyName("level")]
        public long Level { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
