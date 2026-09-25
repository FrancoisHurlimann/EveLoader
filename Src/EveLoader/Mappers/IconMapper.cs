using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class IconMapper
{
    public static Icon ToDbEntity(this Console.StaticDataModels.IconFile model)
        => new Icon
        {
            Key = model.Key,
            IconFile = model.IconFileName
        };
}
