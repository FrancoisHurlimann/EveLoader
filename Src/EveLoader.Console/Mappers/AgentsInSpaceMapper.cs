using System;
using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class AgentsInSpaceMapper
{
    public static EveLoader.Entities.Db.AgentsInSpace ToDbEntity(this EveLoader.Entities.StaticDataModels.AgentsInSpace model)
    {
        return new EveLoader.Entities.Db.AgentsInSpace
        {
            Key = model.Key,
            DungeonID = model.DungeonID,
            SolarSystemID = model.SolarSystemID,
            SpawnPointID = model.SpawnPointID,
            TypeID = model.TypeID
        };
    }
}
