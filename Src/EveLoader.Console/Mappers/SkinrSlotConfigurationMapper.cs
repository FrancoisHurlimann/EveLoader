using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrSlotConfigurationMapper
{
    public static SkinrSlotConfiguration ToDbEntity(this Console.StaticDataModels.SkinrSlotConfigurationFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrSlotConfigurationFile, SkinrSlotConfiguration>();
}
