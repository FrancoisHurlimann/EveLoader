using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class TypeDogmaMapper
{
    public static TypeDogma ToDbEntity(this Console.StaticDataModels.TypeDogmaFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TypeDogmaFile, TypeDogma>();
}
