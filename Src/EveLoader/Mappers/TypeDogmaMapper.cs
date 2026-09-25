using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class TypeDogmaMapper
{
    public static TypeDogma ToDbEntity(this Console.StaticDataModels.TypeDogmaFile model)
        => new TypeDogma
        {
            Key = model.Key,
            DogmaAttributes = model.DogmaAttributes?.Select(d => new TypeDogmaAttribute
            {
                AttributeID = d.AttributeID,
                Value = d.Value
            }).ToList()
        };
}
