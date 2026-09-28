using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class GraphicMaterialSet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public double ColorHullA { get; set; }

        public double ColorHullB { get; set; }

        public double ColorHullG { get; set; }

        public double ColorHullR { get; set; }

        public double ColorPrimaryA { get; set; }

        public double ColorPrimaryB { get; set; }

        public double ColorPrimaryG { get; set; }

        public double ColorPrimaryR { get; set; }

        public double ColorSecondaryA { get; set; }

        public double ColorSecondaryB { get; set; }

        public double ColorSecondaryG { get; set; }

        public double ColorSecondaryR { get; set; }

        public double ColorWindowA { get; set; }

        public double ColorWindowB { get; set; }

        public double ColorWindowG { get; set; }

        public double ColorWindowR { get; set; }

        public string Description { get; set; }

        public string? SofFactionName { get; set; }

        public string? SofRaceHint { get; set; }
    }

    //public class Color
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public long Key { get; set; }

    //    public double A { get; set; }

    //    public double B { get; set; }

    //    public double G { get; set; }

    //    public double R { get; set; }
    //}
}
