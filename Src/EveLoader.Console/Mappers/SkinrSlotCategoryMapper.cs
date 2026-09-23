using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrSlotCategoryMapper
{
    public static SkinrSlotCategory ToDbEntity(this Console.StaticDataModels.SkinrSlotCategoryFile model)
        => new SkinrSlotCategory
        {
            Key = model.Key,
            Name = model.Name
        };
}
