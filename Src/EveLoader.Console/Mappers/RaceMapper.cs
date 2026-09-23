using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class RaceMapper
{
    public static Race ToDbEntity(this Console.StaticDataModels.RaceFile model)
        => new Race
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            IconID = model.IconID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            ShipTypeID = model.ShipTypeID,
            Skills = model.Skills?.Select(s => new RaceSkill { Key = s.Key, Value = s.Value }).ToList()
        };
}
