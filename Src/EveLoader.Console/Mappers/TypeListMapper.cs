using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class TypeListMapper
{
    public static TypeList ToDbEntity(this Console.StaticDataModels.TypeListFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TypeListFile, TypeList>();
}
