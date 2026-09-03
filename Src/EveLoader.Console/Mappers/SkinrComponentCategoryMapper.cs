using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrComponentCategoryMapper
{
    public static EveLoader.Entities.Db.SkinrComponentCategory ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrComponentCategory model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrComponentCategory, EveLoader.Entities.Db.SkinrComponentCategory>();
}
