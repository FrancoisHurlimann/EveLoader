using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class StationServiceMapper
{
    public static EveLoader.Entities.Db.StationService ToDbEntity(this EveLoader.Entities.StaticDataModels.StationService model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.StationService, EveLoader.Entities.Db.StationService>();
}
