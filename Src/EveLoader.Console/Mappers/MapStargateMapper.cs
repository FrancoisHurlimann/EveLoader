using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapStargateMapper
{
    public static MapStargate ToDbEntity(this Console.StaticDataModels.MapStargateFile model)
        => new MapStargate
        {
            Key = model.Key,
            Destination = model.Destination == null
                ? null
                : new StargateDestination
                {
                    SolarSystemID = model.Destination.SolarSystemID,
                    StargateID = model.Destination.StargateID
                },
            Position = model.Position == null
                ? null
                : new Position
                {
                    X = model.Position.X,
                    Y = model.Position.Y,
                    Z = model.Position.Z
                },
            SolarSystemID = model.SolarSystemID,
            TypeID = model.TypeID
        };
}
