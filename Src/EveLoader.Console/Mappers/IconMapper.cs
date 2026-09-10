using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class IconMapper
{
    public static Icon ToDbEntity(this Console.StaticDataModels.IconFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.IconFile, Icon>();
}
