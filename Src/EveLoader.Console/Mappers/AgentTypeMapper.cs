using System;
using EveLoader.Console.Entities;
using EveLoader.Console.StaticDataModels;

namespace EveLoader.Mappers;

public static class AgentTypeMapper
{
    public static AgentType ToDbEntity(this Console.StaticDataModels.AgentTypeFile model)
    {
        return new AgentType
        {
            Key = model.Key,
            Name = model.Name
        };
    }
}
