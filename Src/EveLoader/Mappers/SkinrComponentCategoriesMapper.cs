using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrComponentCategoriesMapper
{
    public static SkinrComponentCategories ToEntity(this Console.StaticDataModels.SkinrComponentCategoriesFile model)
    {
        return new SkinrComponentCategories
        {
            Key = model._key,
            Name = model.name
        };
    }
}
