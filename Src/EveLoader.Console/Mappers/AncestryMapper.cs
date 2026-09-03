using System;
using System.Collections.Generic;
using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class AncestryMapper
{
    public static EveLoader.Entities.Db.Ancestry ToDbEntity(this EveLoader.Entities.StaticDataModels.Ancestry model)
    {
        return new EveLoader.Entities.Db.Ancestry
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
