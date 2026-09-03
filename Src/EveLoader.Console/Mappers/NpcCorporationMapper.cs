using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class NpcCorporationMapper
{
    public static EveLoader.Entities.Db.NpcCorporation ToDbEntity(this EveLoader.Entities.StaticDataModels.NpcCorporation model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.NpcCorporation, EveLoader.Entities.Db.NpcCorporation>();
}
