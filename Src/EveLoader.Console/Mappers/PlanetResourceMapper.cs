using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class PlanetResourceMapper
{
    public static EveLoader.Entities.Db.PlanetResource ToDbEntity(this EveLoader.Entities.StaticDataModels.PlanetResource model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.PlanetResource, EveLoader.Entities.Db.PlanetResource>();
}
