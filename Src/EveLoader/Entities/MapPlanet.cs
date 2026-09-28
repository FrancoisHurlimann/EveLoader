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

        public List<long>? AsteroidBeltIDs { get; set; }

        public long HeightMap1 { get; set; }

        public long HeightMap2 { get; set; }

        public bool Population { get; set; }

        public long ShaderPreset { get; set; }

        public long CelestialIndex { get; set; }

        public List<long>? MoonIDs { get; set; }

        public List<long>? NpcStationIDs { get; set; }

        public long OrbitID { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public double Radius { get; set; }

        public long SolarSystemID { get; set; }

        public double Density { get; set; }

        public double Eccentricity { get; set; }

        public double EscapeVelocity { get; set; }

        public bool Locked { get; set; }

        public double MassDust { get; set; }

        public double MassGas { get; set; }

        public double OrbitPeriod { get; set; }

        public double OrbitRadius { get; set; }

        public double? Pressure { get; set; }

        public double RotationRate { get; set; }

        public string? SpectralClass { get; set; }

        public double SurfaceGravity { get; set; }

        public double Temperature { get; set; }

        public long TypeID { get; set; }
    }



 
}
