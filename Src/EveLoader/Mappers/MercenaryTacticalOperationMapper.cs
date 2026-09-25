using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MercenaryTacticalOperationMapper
{
    public static MercenaryTacticalOperation ToDbEntity(this Console.StaticDataModels.MercenaryTacticalOperationFile model)
        => new MercenaryTacticalOperation
        {
            Key = model.Key,
            AnarchyImpact = model.AnarchyImpact,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            DevelopmentImpact = model.DevelopmentImpact,
            DungeonID = model.DungeonID,
            InfomorphBonus = model.InfomorphBonus,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
