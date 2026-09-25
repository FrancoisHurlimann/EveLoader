using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class GroupMapper
{
    public static Group ToDbEntity(this Console.StaticDataModels.GroupFile model)
        => new Group
        {
            Key = model.Key,
            Anchorable = model.Anchorable,
            Anchored = model.Anchored,
            CategoryID = model.CategoryID,
            FittableNonSingleton = model.FittableNonSingleton,
            IconID = model.IconID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            Published = model.Published,
            UseBasePrice = model.UseBasePrice
        };
}
