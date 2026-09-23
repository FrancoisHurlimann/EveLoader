using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CompressibleTypeMapper
{
    public static CompressibleType ToDbEntity(this Console.StaticDataModels.CompressibleTypeFile model)
        => new CompressibleType
        {
            Key = model.Key,
            CompressedTypeID = model.CompressedTypeID
        };
}
