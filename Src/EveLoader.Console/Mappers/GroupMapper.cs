using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class GroupMapper
{
    public static EveLoader.Entities.Db.Group ToDbEntity(this EveLoader.Entities.StaticDataModels.Group model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Group, EveLoader.Entities.Db.Group>();
}
