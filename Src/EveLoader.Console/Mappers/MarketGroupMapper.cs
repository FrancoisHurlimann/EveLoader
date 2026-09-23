using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MarketGroupMapper
{
    public static MarketGroup ToDbEntity(this Console.StaticDataModels.MarketGroupFile model)
        => new MarketGroup
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            HasTypes = model.HasTypes,
            IconID = model.IconID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            ParentGroupID = model.ParentGroupID
        };
}
