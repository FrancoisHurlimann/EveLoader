using System;
using EveLoaderEntities;
using EveLoader.Console.StaticDataModels;

namespace EveLoader.Mappers;

public static class AncestryMapper
{
    public static Ancestry ToDbEntity(this Console.StaticDataModels.AncestryFile model)
    {
        return new Ancestry
        {
            Key = model.Key,
            BloodlineID = model.BloodlineID,
            Charisma = model.Charisma,
            Description = model.Description?.GetValueOrDefault("en") ?? string.Empty,
            IconID = model.IconID,
            Intelligence = model.Intelligence,
            Memory = model.Memory,
            Name = model.Name?.GetValueOrDefault("en") ?? string.Empty,
            Perception = model.Perception,
            ShortDescription = model.ShortDescription,
            Willpower = model.Willpower
        };
    }
}
