using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class DogmaAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long AttributeCategoryID { get; set; }

        public long DataType { get; set; }

        public double DefaultValue { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public bool DisplayWhenZero { get; set; }

        public bool HighIsGood { get; set; }

        public long? IconID { get; set; }

        public string Name { get; set; }

        public bool Published { get; set; }

        public bool Stackable { get; set; }

        public string TooltipDescription { get; set; }

        public string TooltipTitle { get; set; }

        public long? UnitID { get; set; }
    }
}
