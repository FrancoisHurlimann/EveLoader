using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MasteryMapper
{
    public static EveLoader.Entities.Db.Mastery ToDbEntity(this EveLoader.Entities.StaticDataModels.Mastery model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Mastery, EveLoader.Entities.Db.Mastery>();
}
