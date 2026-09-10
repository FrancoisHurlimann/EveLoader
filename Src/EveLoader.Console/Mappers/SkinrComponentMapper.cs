using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrComponentMapper
{
    public static SkinrComponent ToDbEntity(this Console.StaticDataModels.SkinrComponentFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrComponentFile, SkinrComponent>();
}
