using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrComponentCategoriesMapper
{
    public static EveLoader.Entities.Db.SkinrComponentCategories ToEntity(this EveLoader.Entities.StaticDataModels.SkinrComponentCategories model)
    {
        return new EveLoader.Entities.Db.SkinrComponentCategories
        {
            key = model._key,
            name = model.name
        };
    }
}
