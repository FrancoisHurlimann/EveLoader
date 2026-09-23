using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class NpcStationMapper
{
    public static NpcStation ToDbEntity(this Console.StaticDataModels.NpcStationFile model)
        => new NpcStation
        {
            Key = model.Key,
            CelestialIndex = model.CelestialIndex,
            OperationID = model.OperationID,
            OrbitID = model.OrbitID,
            OrbitIndex = model.OrbitIndex,
            OwnerID = model.OwnerID,
            Position = model.Position == null ? null : new NpcStationPosition
            {
                X = model.Position.X,
                Y = model.Position.Y,
                Z = model.Position.Z
            },
            ReprocessingEfficiency = model.ReprocessingEfficiency,
            ReprocessingHangarFlag = model.ReprocessingHangarFlag,
            ReprocessingStationsTake = model.ReprocessingStationsTake,
            SolarSystemID = model.SolarSystemID,
            TypeID = model.TypeID,
            UseOperationName = model.UseOperationName
        };
}
