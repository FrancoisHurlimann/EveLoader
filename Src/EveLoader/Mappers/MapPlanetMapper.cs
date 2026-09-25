using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MapPlanetMapper
{
    public static MapPlanet ToDbEntity(this Console.StaticDataModels.MapPlanetFile model)
        => new MapPlanet
        {
            Key = model.Key,
            AsteroidBeltIDs = model.AsteroidBeltIDs?.ToList(),
            Attributes = model.Attributes == null
                ? null
                : new PlanetAttributes
                {
                    HeightMap1 = model.Attributes.HeightMap1,
                    HeightMap2 = model.Attributes.HeightMap2,
                    Population = model.Attributes.Population,
                    ShaderPreset = model.Attributes.ShaderPreset
                },
            CelestialIndex = model.CelestialIndex,
            MoonIDs = model.MoonIDs?.ToList(),
            NpcStationIDs = model.NpcStationIDs?.ToList(),
            OrbitID = model.OrbitID,
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
