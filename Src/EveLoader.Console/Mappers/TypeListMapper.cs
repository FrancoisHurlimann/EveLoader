using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class TypeListMapper
{
    public static TypeList ToDbEntity(this Console.StaticDataModels.TypeListFile model)
        => new TypeList
        {
            Key = model.Key,
            IncludedCategoryIDs = model.IncludedCategoryIDs?.ToList(),
            IncludedGroupIDs = model.IncludedGroupIDs?.ToList(),
            IncludedTypeIDs = model.IncludedTypeIDs?.ToList(),
            Name = model.Name
        };
}
