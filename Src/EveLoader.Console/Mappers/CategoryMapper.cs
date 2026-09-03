using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CategoryMapper
{
    public static EveLoader.Entities.Db.Category ToDbEntity(this EveLoader.Entities.StaticDataModels.Category model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Category, EveLoader.Entities.Db.Category>();
}
