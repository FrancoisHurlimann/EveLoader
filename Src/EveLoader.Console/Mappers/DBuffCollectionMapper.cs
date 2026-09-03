using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DBuffCollectionMapper
{
    public static EveLoader.Entities.Db.DBuffCollection ToDbEntity(this EveLoader.Entities.StaticDataModels.DBuffCollection model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.DBuffCollection, EveLoader.Entities.Db.DBuffCollection>();
}
