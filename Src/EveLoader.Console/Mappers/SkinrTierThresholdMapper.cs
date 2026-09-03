using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrTierThresholdMapper
{
    public static EveLoader.Entities.Db.SkinrTierThreshold ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrTierThreshold model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrTierThreshold, EveLoader.Entities.Db.SkinrTierThreshold>();
}
