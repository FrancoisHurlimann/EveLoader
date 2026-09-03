using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class PlanetSchematicMapper
{
    public static EveLoader.Entities.Db.PlanetSchematic ToDbEntity(this EveLoader.Entities.StaticDataModels.PlanetSchematic model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.PlanetSchematic, EveLoader.Entities.Db.PlanetSchematic>();
}
