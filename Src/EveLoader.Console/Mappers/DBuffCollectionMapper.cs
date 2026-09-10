using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DBuffCollectionMapper
{
    public static DBuffCollection ToDbEntity(this Console.StaticDataModels.DBuffCollectionFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.DBuffCollectionFile, DBuffCollection>();
}
