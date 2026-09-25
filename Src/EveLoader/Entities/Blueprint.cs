using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Blueprint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public BlueprintActivities Activities { get; set; }

        public long BlueprintTypeID { get; set; }

        public long MaxProductionLimit { get; set; }
    }

    public class BlueprintActivities
    {
        [Key]
        public long Key { get; set; }

        public long BlueprintId { get; set; }

        public long? CopyingId { get; set; }

        public BlueprintCopying? Copying { get; set; }

        public long? InventionId { get; set; }

        public BlueprintInvention? Invention { get; set; }

        public long? ManufacturingId { get; set; }

        public BlueprintManufacturing? Manufacturing { get; set; }

        public long? ResearchMaterialId { get; set; }

        public BlueprintResearchMaterial? ResearchMaterial { get; set; }

        public long? ResearchTimeId { get; set; }

        public BlueprintResearchTime? ResearchTime { get; set; }
    }

    public class BlueprintCopying
    {
        [Key]
        public long Key { get; set; }
        
        public long Time { get; set; }
    }

    public class BlueprintInvention
    {
        [Key]
        public long Key { get; set; }

        public List<BlueprintInventionMaterial> Materials { get; set; }

        public List<BlueprintInventionProduct> Products { get; set; }

        public List<BlueprintInventionSkill> Skills { get; set; }

        public long Time { get; set; }
    }

    public class BlueprintInventionMaterial
    {
        [Key]
        public long Key { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

    }

    public class BlueprintInventionProduct
    {
        [Key]
        public long Key { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

        public double? Probability { get; set; }
    }

    public class BlueprintInventionSkill
    {
        [Key]
        public long Key { get; set; }

        public long Level { get; set; }

        public long TypeID { get; set; }
    }

    public class BlueprintManufacturing
    {
        [Key]
        public long Key { get; set; }

        public List<BlueprintManufacturingMaterial> Materials { get; set; }

        public List<BlueprintManufacturingProduct> Products { get; set; }

        public List<BlueprintManufacturingSkill> Skills { get; set; }

        public long Time { get; set; }
    }

    public class BlueprintManufacturingMaterial
    {
        [Key]
        public long Key { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

    }

    public class BlueprintManufacturingProduct
    {
        [Key]
        public long Key { get; set; }

        public long Quantity { get; set; }

        public long TypeID { get; set; }

        //public double? Probability { get; set; }
    }

    public class BlueprintManufacturingSkill
    {
        [Key]
        public long Key { get; set; }

        public long Level { get; set; }

        public long TypeID { get; set; }
    }



    public class BlueprintResearchMaterial
    {
        [Key]
        public long Key { get; set; }

        public long Time { get; set; }
    }

    public class BlueprintResearchTime
    {
        [Key]
        public long Key { get; set; }

        public long Time { get; set; }
    }

    //public class BlueprintProduct
    //{
    //    [Key]
    //    public long Key { get; set; }

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
    //    public long Key { get; set; }

    //    [JsonPropertyName("level")]
    //    public long Level { get; set; }

    //    [JsonPropertyName("typeID")]
    //    public long TypeID { get; set; }
    //}
}
