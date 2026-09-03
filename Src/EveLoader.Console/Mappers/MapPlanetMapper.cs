using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapPlanetMapper
{
    public static EveLoader.Entities.Db.MapPlanet ToDbEntity(this EveLoader.Entities.StaticDataModels.MapPlanet model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapPlanet, EveLoader.Entities.Db.MapPlanet>();
}
