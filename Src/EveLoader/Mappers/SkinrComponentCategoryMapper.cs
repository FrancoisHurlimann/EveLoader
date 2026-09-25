using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrComponentCategoryMapper
{
    public static SkinrComponentCategory ToDbEntity(this Console.StaticDataModels.SkinrComponentCategoryFile model)
        => new SkinrComponentCategory
        {
            Key = model.Key,
            Name = model.Name
        };
}
