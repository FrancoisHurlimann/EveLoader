using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapSolarSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public bool? Border { get; set; }

        public long ConstellationID { get; set; }

        public bool? Corridor { get; set; }

        public bool? Fringe { get; set; }

        public bool? Hub { get; set; }

        public bool? International { get; set; }

        public double Luminosity { get; set; }

        public string? Name { get; set; }

        public List<long>? PlanetIDs { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public double? Position2DX { get; set; }

        public double? Position2DY { get; set; }

        public double Radius { get; set; }

        public long RegionID { get; set; }

        public bool? Regional { get; set; }

        public string? SecurityClass { get; set; }

        public double SecurityStatus { get; set; }

        public long StarID { get; set; }

        public List<long>? StargateIDs { get; set; }
    }

  
}
