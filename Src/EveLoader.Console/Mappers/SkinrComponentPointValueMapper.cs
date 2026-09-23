using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrComponentPointValueMapper
{
    public static SkinrComponentPointValue ToDbEntity(this Console.StaticDataModels.SkinrComponentPointValueFile model)
        => new SkinrComponentPointValue
        {
            Key = model.Key,
            Value = model.Value?.Select(v => new SkinrComponentPointValueEntry { Key = v.Key, Value = v.Value }).ToList()
        };
}
