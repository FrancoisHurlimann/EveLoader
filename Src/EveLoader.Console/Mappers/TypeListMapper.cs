using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TypeListMapper
{
    public static EveLoader.Entities.Db.TypeList ToDbEntity(this EveLoader.Entities.StaticDataModels.TypeList model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.TypeList, EveLoader.Entities.Db.TypeList>();
}
