using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class FactionMapper
{
    public static EveLoader.Entities.Db.Faction ToDbEntity(this EveLoader.Entities.StaticDataModels.Faction model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Faction, EveLoader.Entities.Db.Faction>();
}
