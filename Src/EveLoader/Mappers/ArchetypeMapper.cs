using System;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class ArchetypeMapper
{
    public static Archetype ToDbEntity(this Console.StaticDataModels.ArchetypeFile model)
    {
        return new Archetype
        {
            Key = model.Key,
            Description = model.Description?.GetValueOrDefault("en") ?? string.Empty,
            Title = model.Title?.GetValueOrDefault("en") ?? string.Empty,
        };
    }
}
