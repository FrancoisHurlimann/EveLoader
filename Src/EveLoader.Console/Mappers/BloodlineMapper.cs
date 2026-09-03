using System;
using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class BloodlineMapper
{
    public static EveLoader.Entities.Db.Bloodline ToDbEntity(this EveLoader.Entities.StaticDataModels.Bloodline model)
    {
        return new EveLoader.Entities.Db.Bloodline
        {
            Key = model.Key,
            Charisma = model.Charisma,
            CorporationID = model.CorporationID,
            Description = model.Description?.GetValueOrDefault("en") ?? string.Empty,
            IconID = model.IconID,
            Intelligence = model.Intelligence,
            Memory = model.Memory,
            Name = model.Name?.GetValueOrDefault("en") ?? string.Empty,
            Perception = model.Perception,
            RaceID = model.RaceID,
            Willpower = model.Willpower
        };
    }
}
