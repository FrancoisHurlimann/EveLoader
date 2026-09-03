using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DynamicItemAttributeMapper
{
    public static EveLoader.Entities.Db.DynamicItemAttribute ToDbEntity(this EveLoader.Entities.StaticDataModels.DynamicItemAttribute model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.DynamicItemAttribute, EveLoader.Entities.Db.DynamicItemAttribute>();
}
