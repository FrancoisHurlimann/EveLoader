using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CorporationActivityMapper
{
    public static EveLoader.Entities.Db.CorporationActivity ToDbEntity(this EveLoader.Entities.StaticDataModels.CorporationActivity model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.CorporationActivity, EveLoader.Entities.Db.CorporationActivity>();
}
