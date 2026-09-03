using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MissionMapper
{
    public static EveLoader.Entities.Db.Mission ToDbEntity(this EveLoader.Entities.StaticDataModels.Mission model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Mission, EveLoader.Entities.Db.Mission>();
}
