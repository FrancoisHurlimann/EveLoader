using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class IconMapper
{
    public static EveLoader.Entities.Db.Icon ToDbEntity(this EveLoader.Entities.StaticDataModels.Icon model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Icon, EveLoader.Entities.Db.Icon>();
}
