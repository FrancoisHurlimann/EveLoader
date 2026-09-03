using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapAsteroidBeltMapper
{
    public static EveLoader.Entities.Db.MapAsteroidBelt ToDbEntity(this EveLoader.Entities.StaticDataModels.MapAsteroidBelt model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapAsteroidBelt, EveLoader.Entities.Db.MapAsteroidBelt>();
}
