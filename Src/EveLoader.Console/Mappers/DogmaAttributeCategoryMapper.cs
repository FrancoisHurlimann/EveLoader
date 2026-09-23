using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DogmaAttributeCategoryMapper
{
    public static DogmaAttributeCategory ToDbEntity(this Console.StaticDataModels.DogmaAttributeCategoryFile model)
        => new DogmaAttributeCategory
        {
            Key = model.Key,
            Description = model.Description,
            Name = model.Name
        };
}
