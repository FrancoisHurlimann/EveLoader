using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class ShipTreeFactionMapper
{
    public static ShipTreeFaction ToDbEntity(this Console.StaticDataModels.ShipTreeFactionFile model)
        => new ShipTreeFaction
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            Elements = model.Elements?.Select(e => new ShipTreeFactionElement { Key = e.Key, Value = e.Value }).ToList(),
            Icon = model.Icon
        };
}
