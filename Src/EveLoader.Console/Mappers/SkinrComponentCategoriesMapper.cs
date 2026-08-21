using EveLoader.Entities;

namespace EveLoader.Mappers;

public static class SkinrComponentCategoriesMapper
{
    public static Entities.SkinrComponentCategories ToEntity(this StaticDataModels.SkinrComponentCategories model)
    {
        return new Entities.SkinrComponentCategories
        {
            key = model._key,
            name = model.name
        };
    }
}
