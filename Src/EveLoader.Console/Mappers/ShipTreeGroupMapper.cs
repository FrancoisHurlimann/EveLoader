using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class ShipTreeGroupMapper
{
    public static ShipTreeGroup ToDbEntity(this Console.StaticDataModels.ShipTreeGroupFile model)
        => new ShipTreeGroup
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            Elements = model.Elements?.Select(e => new ShipTreeGroupElement { Key = e.Key, Value = e.Value }).ToList(),
            Icon = model.Icon,
            IconLarge = model.IconLarge,
            IconSmall = model.IconSmall,
            IconSmallNPC = model.IconSmallNPC,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            PreReqSkills = model.PreReqSkills?.Select(p => new ShipTreeGroupPreReqSkillFaction
            {
                Key = p.Key,
                Skills = p.Skills?.Select(s => new ShipTreeGroupPreReqSkill
                {
                    Key = s.Key,
                    Display = s.Display,
                    Level = s.Level
                }).ToList()
            }).ToList()
        };
}
