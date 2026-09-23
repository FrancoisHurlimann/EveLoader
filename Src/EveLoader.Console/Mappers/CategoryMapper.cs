using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class CategoryMapper
{
    public static Category ToDbEntity(this Console.StaticDataModels.CategoryFile model)
        => new Category
        {
            Key = model.Key,
            IconID = model.IconID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            Published = model.Published
        };
}
