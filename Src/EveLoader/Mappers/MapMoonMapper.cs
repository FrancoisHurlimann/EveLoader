using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MapMoonMapper
{
    public static MapMoon ToDbEntity(this Console.StaticDataModels.MapMoonFile model)
        => new MapMoon
        {
            Key = model.Key,
            HeightMap1 = model.Attributes.HeightMap1,
            HeightMap2 = model.Attributes.HeightMap2,
            Population = model.Attributes.Population,
            ShaderPreset = model.Attributes.ShaderPreset,
            CelestialIndex = model.CelestialIndex,
            OrbitID = model.OrbitID,
            X = model.Position.X,
            Y = model.Position.Y,
            Z = model.Position.Z,
            Radius = model.Radius,
            SolarSystemID = model.SolarSystemID,
            Density = model.Statistics?.Density ?? default,
            Eccentricity = model.Statistics?.Eccentricity ?? default,
            EscapeVelocity = model.Statistics?.EscapeVelocity ?? default,
            Locked = model.Statistics?.Locked ?? default,
            MassDust = model.Statistics?.MassDust ?? default,
            MassGas = model.Statistics?.MassGas ?? default,
            OrbitPeriod = model.Statistics?.OrbitPeriod ?? default,
            OrbitRadius = model.Statistics?.OrbitRadius ?? default,
            Pressure = model.Statistics?.Pressure,
            RotationRate = model.Statistics?.RotationRate ?? default,
            SpectralClass = model.Statistics?.SpectralClass,
            SurfaceGravity = model.Statistics?.SurfaceGravity ?? default,
            Temperature = model.Statistics?.Temperature ?? default,
            TypeID = model.TypeID
        };
}
