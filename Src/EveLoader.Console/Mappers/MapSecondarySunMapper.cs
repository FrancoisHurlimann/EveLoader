using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapSecondarySunMapper
{
    public static EveLoader.Entities.Db.MapSecondarySun ToDbEntity(this EveLoader.Entities.StaticDataModels.MapSecondarySun model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapSecondarySun, EveLoader.Entities.Db.MapSecondarySun>();
}
