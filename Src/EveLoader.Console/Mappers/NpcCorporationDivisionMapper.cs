using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class NpcCorporationDivisionMapper
{
    public static EveLoader.Entities.Db.NpcCorporationDivision ToDbEntity(this EveLoader.Entities.StaticDataModels.NpcCorporationDivision model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.NpcCorporationDivision, EveLoader.Entities.Db.NpcCorporationDivision>();
}
