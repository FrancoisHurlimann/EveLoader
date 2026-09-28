using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MapSecondarySunMapper
{
    public static MapSecondarySun ToDbEntity(this Console.StaticDataModels.MapSecondarySunFile model)
        => new MapSecondarySun
        {
            Key = model.Key,
            EffectBeaconTypeID = model.EffectBeaconTypeID,
            X = model.Position.X,
            Y = model.Position.Y,
            Z = model.Position.Z,
            SolarSystemID = model.SolarSystemID,
            TypeID = model.TypeID
        };
}
