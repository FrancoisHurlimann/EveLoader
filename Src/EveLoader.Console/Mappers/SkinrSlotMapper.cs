using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrSlotMapper
{
    public static SkinrSlot ToDbEntity(this Console.StaticDataModels.SkinrSlotFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrSlotFile, SkinrSlot>();
}
