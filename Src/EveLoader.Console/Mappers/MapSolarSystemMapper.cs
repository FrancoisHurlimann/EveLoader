using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapSolarSystemMapper
{
    public static EveLoader.Entities.Db.MapSolarSystem ToDbEntity(this EveLoader.Entities.StaticDataModels.MapSolarSystem model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapSolarSystem, EveLoader.Entities.Db.MapSolarSystem>();
}
