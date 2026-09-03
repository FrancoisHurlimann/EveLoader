using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class ShipTreeFactionMapper
{
    public static EveLoader.Entities.Db.ShipTreeFaction ToDbEntity(this EveLoader.Entities.StaticDataModels.ShipTreeFaction model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.ShipTreeFaction, EveLoader.Entities.Db.ShipTreeFaction>();
}
