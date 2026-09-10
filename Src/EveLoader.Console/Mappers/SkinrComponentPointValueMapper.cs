using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrComponentPointValueMapper
{
    public static SkinrComponentPointValue ToDbEntity(this Console.StaticDataModels.SkinrComponentPointValueFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrComponentPointValueFile, SkinrComponentPointValue>();
}
