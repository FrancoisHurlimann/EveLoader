using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MetaGroupMapper
{
    public static MetaGroup ToDbEntity(this Console.StaticDataModels.MetaGroupFile model)
        => new MetaGroup
        {
            Key = model.Key,
            Color = model.Color == null
                ? null
                : new ColorRGB
                {
                    R = model.Color.R,
                    G = model.Color.G,
                    B = model.Color.B
                },
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            IconID = model.IconID,
            IconSuffix = model.IconSuffix,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
