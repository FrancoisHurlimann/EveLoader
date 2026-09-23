using EveLoader.Console.Entities;

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
            Position = model.Position == null
                ? null
                : new Position
                {
                    X = model.Position.X,
                    Y = model.Position.Y,
                    Z = model.Position.Z
                },
            Radius = model.Radius,
            SolarSystemID = model.SolarSystemID,
            Statistics = model.Statistics == null
                ? null
                : new CelestialStatistics
                {
                    Density = model.Statistics.Density,
                    Eccentricity = model.Statistics.Eccentricity,
                    EscapeVelocity = model.Statistics.EscapeVelocity,
                    Locked = model.Statistics.Locked,
                    MassDust = model.Statistics.MassDust,
                    MassGas = model.Statistics.MassGas,
                    OrbitPeriod = model.Statistics.OrbitPeriod,
                    OrbitRadius = model.Statistics.OrbitRadius,
                    Pressure = model.Statistics.Pressure,
                    RotationRate = model.Statistics.RotationRate,
                    SpectralClass = model.Statistics.SpectralClass,
                    SurfaceGravity = model.Statistics.SurfaceGravity,
                    Temperature = model.Statistics.Temperature
                },
            TypeID = model.TypeID
        };
}
