using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MetaGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public ColorRGB Color { get; set; }

        public string Description { get; set; }

        public long? IconID { get; set; }

        public string IconSuffix { get; set; }

        public string Name { get; set; }
    }

    public class ColorRGB
    {
        [Key]
        public long Key { get; set; }

        public double R { get; set; }

        public double G { get; set; }

        public double B { get; set; }
    }
}
