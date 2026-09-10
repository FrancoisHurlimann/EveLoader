using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrTierThresholdMapper
{
    public static SkinrTierThreshold ToDbEntity(this Console.StaticDataModels.SkinrTierThresholdFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrTierThresholdFile, SkinrTierThreshold>();
}
