using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class ShipTreeElementMapper
{
    public static ShipTreeElement ToDbEntity(this Console.StaticDataModels.ShipTreeElementFile model)
        => new ShipTreeElement
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            Icon = model.Icon,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
