using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class TypeElementMapper
{
    public static TypeElement ToDbEntity(this Console.StaticDataModels.TypeElementFile model)
        => new TypeElement
        {
            Key = model.Key,
            Elements = model.Elements?.Select(e => new TypeElementEntry { Key = e.Key, Value = e.Value }).ToList()
        };
}
