using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class MapMoon
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public PlanetAttributes Attributes { get; set; }

        public long CelestialIndex { get; set; }

        public long OrbitID { get; set; }

        public Position Position { get; set; }

        public double Radius { get; set; }

        public long SolarSystemID { get; set; }

        public CelestialStatistics Statistics { get; set; }

        public long TypeID { get; set; }
    }
}
