using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrSlotNameMapper
{
    public static SkinrSlotName ToDbEntity(this Console.StaticDataModels.SkinrSlotNameFile model)
        => new SkinrSlotName
        {
            Key = model.Key,
            Name = model.Name
        };
}
