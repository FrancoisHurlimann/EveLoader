using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CompressibleTypeMapper
{
    public static CompressibleType ToDbEntity(this Console.StaticDataModels.CompressibleTypeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CompressibleTypeFile, CompressibleType>();
}
