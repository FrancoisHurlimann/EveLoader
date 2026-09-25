using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class TypeMaterialMapper
{
    public static TypeMaterial ToDbEntity(this Console.StaticDataModels.TypeMaterialFile model)
        => new TypeMaterial
        {
            Key = model.Key,
            Materials = model.Materials?.Select(m => new TypeMaterialEntry { MaterialTypeID = m.MaterialTypeID, Quantity = m.Quantity }).ToList()
        };
}
