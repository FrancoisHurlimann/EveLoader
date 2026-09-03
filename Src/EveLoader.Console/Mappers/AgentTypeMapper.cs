using System;
using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class AgentTypeMapper
{
    public static EveLoader.Entities.Db.AgentType ToDbEntity(this EveLoader.Entities.StaticDataModels.AgentType model)
    {
        return new EveLoader.Entities.Db.AgentType
        {
            Key = model.Key,
            Name = model.Name
        };
    }
}
