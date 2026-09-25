using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrTierThresholdMapper
{
    public static SkinrTierThreshold ToDbEntity(this Console.StaticDataModels.SkinrTierThresholdFile model)
        => new SkinrTierThreshold
        {
            Key = model.Key,
            Value = model.Value?.Select(v => new SkinrTierThresholdEntry { Key = v.Key, Value = v.Value }).ToList()
        };
}
