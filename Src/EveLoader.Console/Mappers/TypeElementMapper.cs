using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TypeElementMapper
{
    public static EveLoader.Entities.Db.TypeElement ToDbEntity(this EveLoader.Entities.StaticDataModels.TypeElement model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.TypeElement, EveLoader.Entities.Db.TypeElement>();
}
