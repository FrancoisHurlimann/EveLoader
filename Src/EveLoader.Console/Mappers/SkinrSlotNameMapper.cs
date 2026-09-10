using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrSlotNameMapper
{
    public static SkinrSlotName ToDbEntity(this Console.StaticDataModels.SkinrSlotNameFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrSlotNameFile, SkinrSlotName>();
}
