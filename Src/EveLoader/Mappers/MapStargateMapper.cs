using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MapStargateMapper
{
    public static MapStargate ToDbEntity(this Console.StaticDataModels.MapStargateFile model)
        => new MapStargate
        {
            Key = model.Key,
            StargateDestinationSolarSystemID = model.Destination.SolarSystemID,
            StargateDestinationStargateID = model.Destination.StargateID,
            X = model.Position.X,
            Y = model.Position.Y,
            Z = model.Position.Z,
            SolarSystemID = model.SolarSystemID,
            TypeID = model.TypeID
        };
}
