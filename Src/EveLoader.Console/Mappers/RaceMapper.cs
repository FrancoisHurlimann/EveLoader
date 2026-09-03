using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class RaceMapper
{
    public static EveLoader.Entities.Db.Race ToDbEntity(this EveLoader.Entities.StaticDataModels.Race model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Race, EveLoader.Entities.Db.Race>();
}
