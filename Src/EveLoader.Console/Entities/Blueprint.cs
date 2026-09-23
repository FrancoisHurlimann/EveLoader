using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Blueprint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public BlueprintActivities Activities { get; set; }

        public long BlueprintTypeID { get; set; }

        public long MaxProductionLimit { get; set; }
    }

    public class BlueprintActivities
    {
        [Key]
        public int id { get; set; }

        public long BlueprintId { get; set; }

        public int? CopyingId { get; set; }

        public BlueprintCopying Copying { get; set; }

        public int? InventionId { get; set; }

        public BlueprintInvention Invention { get; set; }

        public int? ManufacturingId { get; set; }

        public BlueprintManufacturing Manufacturing { get; set; }

        public int? ResearchMaterialId { get; set; }

        public BlueprintResearchMaterial ResearchMaterial { get; set; }

        public int? ResearchTimeId { get; set; }

        public BlueprintResearchTime ResearchTime { get; set; }
    }

    public class BlueprintCopying
    {
        [Key]
        public int id { get; set; }
        
        public long Time { get; set; }
    }

    public class BlueprintInvention
    {
        [Key]
        public int id { get; set; }

        public List<BlueprintInventionMaterial> Materials { get; set; }

        public List<BlueprintInventionProduct> Products { get; set; }

        public List<BlueprintInventionSkill> Skills { get; set; }

        public long Time { get; set; }
    }

    public class BlueprintInventionMaterial
    {
        [Key]
        public int id { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

    }

    public class BlueprintInventionProduct
    {
        [Key]
        public int id { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

        public double? Probability { get; set; }
    }

    public class BlueprintInventionSkill
    {
        [Key]
        public int id { get; set; }

        public long Level { get; set; }

        public long TypeID { get; set; }
    }

    public class BlueprintManufacturing
    {
        [Key]
        public int id { get; set; }

        public List<BlueprintManufacturingMaterial> Materials { get; set; }

        public List<BlueprintManufacturingProduct> Products { get; set; }

        public List<BlueprintManufacturingSkill> Skills { get; set; }

        public long Time { get; set; }
    }

    public class BlueprintManufacturingMaterial
    {
        [Key]
        public int id { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

    }

    public class BlueprintManufacturingProduct
    {
        [Key]
        public int id { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

        public double? Probability { get; set; }
    }

    public class BlueprintManufacturingSkill
    {
        [Key]
        public int id { get; set; }

        public long Level { get; set; }

        public long TypeID { get; set; }
    }



    public class BlueprintResearchMaterial
    {
        [Key]
        public int id { get; set; }

        public long Time { get; set; }
    }

    public class BlueprintResearchTime
    {
        [Key]
        public int id { get; set; }

        public long Time { get; set; }
    }

    //public class BlueprintProduct
    //{
    //    [Key]
    //    public int id { get; set; }

    //    [JsonPropertyName("quantity")]
    //    public long Quantity { get; set; }

    //    [JsonPropertyName("typeID")]
    //    public long TypeID { get; set; }

    //    [JsonPropertyName("probability")]
    //    public double? Probability { get; set; }
    //}

    //public class BlueprintSkill
    //{
    //    [Key]
    //    public int id { get; set; }

    //    [JsonPropertyName("level")]
    //    public long Level { get; set; }

    //    [JsonPropertyName("typeID")]
    //    public long TypeID { get; set; }
    //}
}
