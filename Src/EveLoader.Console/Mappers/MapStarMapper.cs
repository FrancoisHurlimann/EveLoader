using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapStarMapper
{
    public static EveLoader.Entities.Db.MapStar ToDbEntity(this EveLoader.Entities.StaticDataModels.MapStar model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapStar, EveLoader.Entities.Db.MapStar>();
}
