using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrComponentRarityMapper
{
    public static EveLoader.Entities.Db.SkinrComponentRarity ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrComponentRarity model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrComponentRarity, EveLoader.Entities.Db.SkinrComponentRarity>();
}
