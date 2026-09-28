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

        public double PositionX { get; set; }

        public double PositionY { get; set; }

        public double PositionZ { get; set; }

        public double Radius { get; set; }

        public long SolarSystemID { get; set; }

        public double CelestialStatisticsDensity { get; set; }

        public double CelestialStatisticsEccentricity { get; set; }

        public double CelestialStatisticsEscapeVelocity { get; set; }

        public bool CelestialStatisticsLocked { get; set; }

        public double CelestialStatisticsMassDust { get; set; }

        public double CelestialStatisticsMassGas { get; set; }

        public double CelestialStatisticsOrbitPeriod { get; set; }

        public double CelestialStatisticsOrbitRadius { get; set; }

        public double? CelestialStatisticsPressure { get; set; }

        public double CelestialStatisticsRotationRate { get; set; }

        public string? CelestialStatisticsSpectralClass { get; set; }

        public double CelestialStatisticsSurfaceGravity { get; set; }

        public double CelestialStatisticsTemperature { get; set; }

        public long TypeID { get; set; }
    }


}
