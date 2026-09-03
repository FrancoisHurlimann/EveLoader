using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SovereigntyUpgradeMapper
{
    public static EveLoader.Entities.Db.SovereigntyUpgrade ToDbEntity(this EveLoader.Entities.StaticDataModels.SovereigntyUpgrade model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SovereigntyUpgrade, EveLoader.Entities.Db.SovereigntyUpgrade>();
}
