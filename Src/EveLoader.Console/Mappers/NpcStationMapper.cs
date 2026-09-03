using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class NpcStationMapper
{
    public static EveLoader.Entities.Db.NpcStation ToDbEntity(this EveLoader.Entities.StaticDataModels.NpcStation model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.NpcStation, EveLoader.Entities.Db.NpcStation>();
}
