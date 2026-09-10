using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class PlanetSchematicMapper
{
    public static PlanetSchematic ToDbEntity(this Console.StaticDataModels.PlanetSchematicFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.PlanetSchematicFile, PlanetSchematic>();
}
