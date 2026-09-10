using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrSlotCategoryMapper
{
    public static SkinrSlotCategory ToDbEntity(this Console.StaticDataModels.SkinrSlotCategoryFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrSlotCategoryFile, SkinrSlotCategory>();
}
