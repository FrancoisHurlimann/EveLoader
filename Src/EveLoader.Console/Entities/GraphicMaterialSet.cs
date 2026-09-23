using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class GraphicMaterialSet
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public Color ColorHull { get; set; }

        public Color ColorPrimary { get; set; }

        public Color ColorSecondary { get; set; }

        public Color ColorWindow { get; set; }

        public string Description { get; set; }

        public string SofFactionName { get; set; }

        public string SofRaceHint { get; set; }
    }

    public class Color
    {
        [Key]
        public int id { get; set; }

        public double A { get; set; }

        public double B { get; set; }

        public double G { get; set; }

        public double R { get; set; }
    }
}
