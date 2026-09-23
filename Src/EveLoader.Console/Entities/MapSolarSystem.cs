using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class MapSolarSystem
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public bool? Border { get; set; }

        public long ConstellationID { get; set; }

        public bool? Corridor { get; set; }

        public bool? Fringe { get; set; }

        public bool? Hub { get; set; }

        public bool? International { get; set; }

        public double Luminosity { get; set; }

        public string Name { get; set; }

        public List<long> PlanetIDs { get; set; }

        public Position Position { get; set; }

        public Position2D Position2D { get; set; }

        public double Radius { get; set; }

        public long RegionID { get; set; }

        public bool? Regional { get; set; }

        public string SecurityClass { get; set; }

        public double SecurityStatus { get; set; }

        public long StarID { get; set; }

        public List<long> StargateIDs { get; set; }
    }

    public class Position2D
    {
        public double X { get; set; }

        public double Y { get; set; }
    }
}
