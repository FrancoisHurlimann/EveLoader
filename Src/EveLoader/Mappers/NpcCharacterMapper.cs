using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class NpcCharacterMapper
{
    public static NpcCharacter ToDbEntity(this Console.StaticDataModels.NpcCharacterFile model)
        => new NpcCharacter
        {
            Key = model.Key,
            BloodlineID = model.BloodlineID,
            Ceo = model.Ceo,
            CorporationID = model.CorporationID,
            Gender = model.Gender,
            LocationID = model.LocationID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            RaceID = model.RaceID,
            Skills = model.Skills?.Select(s => new NpcCharacterSkill { TypeID = s.TypeID }).ToList(),
            StartDate = model.StartDate,
            UniqueName = model.UniqueName
        };
}
