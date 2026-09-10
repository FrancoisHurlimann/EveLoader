using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DogmaAttributeMapper
{
    public static DogmaAttribute ToDbEntity(this Console.StaticDataModels.DogmaAttributeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.DogmaAttributeFile, DogmaAttribute>();
}
