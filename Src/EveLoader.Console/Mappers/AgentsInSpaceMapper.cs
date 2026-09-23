using System;
using EveLoaderEntities;
using EveLoader.Console.StaticDataModels;

namespace EveLoader.Mappers;

public static class AgentsInSpaceMapper
{
    public static AgentsInSpace ToDbEntity(this Console.StaticDataModels.AgentsInSpaceFile model)
    {
        return new AgentsInSpace
        {
            Key = model.Key,
            DungeonID = model.DungeonID,
            SolarSystemID = model.SolarSystemID,
            SpawnPointID = model.SpawnPointID,
            TypeID = model.TypeID
        };
    }
}
