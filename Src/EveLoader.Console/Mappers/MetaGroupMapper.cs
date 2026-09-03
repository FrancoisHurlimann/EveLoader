using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MetaGroupMapper
{
    public static EveLoader.Entities.Db.MetaGroup ToDbEntity(this EveLoader.Entities.StaticDataModels.MetaGroup model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MetaGroup, EveLoader.Entities.Db.MetaGroup>();
}
