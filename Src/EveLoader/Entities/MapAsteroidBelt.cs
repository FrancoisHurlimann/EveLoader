using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapAsteroidBelt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long CelestialIndex { get; set; }

        public long OrbitID { get; set; }

        public long OrbitIndex { get; set; }

        public Position Position { get; set; }

        public double Radius { get; set; }

        public long SolarSystemID { get; set; }

        public CelestialStatistics Statistics { get; set; }

        public long TypeID { get; set; }
    }

    public class CelestialStatistics
    {
        [Key]
        public long Key { get; set; }

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

        public string SpectralClass { get; set; }

        public double SurfaceGravity { get; set; }

        public double Temperature { get; set; }
    }
}
