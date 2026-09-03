using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MarketGroupMapper
{
    public static EveLoader.Entities.Db.MarketGroup ToDbEntity(this EveLoader.Entities.StaticDataModels.MarketGroup model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MarketGroup, EveLoader.Entities.Db.MarketGroup>();
}
