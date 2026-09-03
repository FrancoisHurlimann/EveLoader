using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TypeMapper
{
    public static EveLoader.Entities.Db.Type ToDbEntity(this EveLoader.Entities.StaticDataModels.Type model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Type, EveLoader.Entities.Db.Type>();
}
