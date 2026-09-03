using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MercenaryTacticalOperationMapper
{
    public static EveLoader.Entities.Db.MercenaryTacticalOperation ToDbEntity(this EveLoader.Entities.StaticDataModels.MercenaryTacticalOperation model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MercenaryTacticalOperation, EveLoader.Entities.Db.MercenaryTacticalOperation>();
}
