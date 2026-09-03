using System;
using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class ArchetypeMapper
{
    public static EveLoader.Entities.Db.Archetype ToDbEntity(this EveLoader.Entities.StaticDataModels.Archetype model)
    {
        return new EveLoader.Entities.Db.Archetype
        {
            Key = model.Key,
            Description = model.Description?.GetValueOrDefault("en") ?? string.Empty,
            Title = model.Title?.GetValueOrDefault("en") ?? string.Empty,
        };
    }
}
