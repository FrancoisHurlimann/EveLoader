using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class TypeElementMapper
{
    public static TypeElement ToDbEntity(this Console.StaticDataModels.TypeElementFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TypeElementFile, TypeElement>();
}
