using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MapAsteroidBeltMapper
{
    public static MapAsteroidBelt ToDbEntity(this Console.StaticDataModels.MapAsteroidBeltFile model)
        => new MapAsteroidBelt
        {
            Key = model.Key,
            CelestialIndex = model.CelestialIndex,
            OrbitID = model.OrbitID,
            OrbitIndex = model.OrbitIndex,
            PositionX = model.Position.X,
            PositionY = model.Position.Y,
            PositionZ = model.Position.Z,
            Radius = model.Radius,
            SolarSystemID = model.SolarSystemID,
            CelestialStatisticsDensity = model.Statistics?.Density ?? default,
            CelestialStatisticsEccentricity = model.Statistics?.Eccentricity ?? default,
            CelestialStatisticsEscapeVelocity = model.Statistics?.EscapeVelocity ?? default,
            CelestialStatisticsLocked = model.Statistics?.Locked ?? default,
            CelestialStatisticsMassDust = model.Statistics?.MassDust ?? default,
            CelestialStatisticsMassGas = model.Statistics?.MassGas ?? default,
            CelestialStatisticsOrbitPeriod = model.Statistics?.OrbitPeriod ?? default,
            CelestialStatisticsOrbitRadius = model.Statistics?.OrbitRadius ?? default,
            CelestialStatisticsPressure = model.Statistics?.Pressure,
            CelestialStatisticsRotationRate = model.Statistics?.RotationRate ?? default,
            CelestialStatisticsSpectralClass = model.Statistics?.SpectralClass,
            CelestialStatisticsSurfaceGravity = model.Statistics?.SurfaceGravity ?? default,
            CelestialStatisticsTemperature = model.Statistics?.Temperature ?? default,
            TypeID = model.TypeID
        };
}
