using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinMapper
{
    public static Skin ToDbEntity(this Console.StaticDataModels.SkinFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinFile, Skin>();
}
