using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapPlanet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<long> AsteroidBeltIDs { get; set; }

        public PlanetAttributes Attributes { get; set; }

        public long CelestialIndex { get; set; }

        public List<long> MoonIDs { get; set; }

        public List<long> NpcStationIDs { get; set; }

        public long OrbitID { get; set; }

        public Position Position { get; set; }

        public double Radius { get; set; }

        public long SolarSystemID { get; set; }

        public CelestialStatistics Statistics { get; set; }

        public long TypeID { get; set; }
    }

    public class PlanetAttributes
    {
        public long HeightMap1 { get; set; }

        public long HeightMap2 { get; set; }

        public bool Population { get; set; }

        public long ShaderPreset { get; set; }
    }
}
