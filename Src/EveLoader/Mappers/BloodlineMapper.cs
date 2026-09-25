using System;
using EveLoaderEntities;
using EveLoader.Console.StaticDataModels;

namespace EveLoader.Mappers;    

public static class BloodlineMapper
{
    public static Bloodline ToDbEntity(this Console.StaticDataModels.BloodlineFile model)
    {
        return new Bloodline
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
