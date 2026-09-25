using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapMoon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
