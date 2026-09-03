using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class StationOperationMapper
{
    public static EveLoader.Entities.Db.StationOperation ToDbEntity(this EveLoader.Entities.StaticDataModels.StationOperation model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.StationOperation, EveLoader.Entities.Db.StationOperation>();
}
