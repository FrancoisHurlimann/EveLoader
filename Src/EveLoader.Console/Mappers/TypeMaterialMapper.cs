using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class TypeMaterialMapper
{
    public static TypeMaterial ToDbEntity(this Console.StaticDataModels.TypeMaterialFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TypeMaterialFile, TypeMaterial>();
}
