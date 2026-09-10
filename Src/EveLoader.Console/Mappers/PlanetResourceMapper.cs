using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class PlanetResourceMapper
{
    public static PlanetResource ToDbEntity(this Console.StaticDataModels.PlanetResourceFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.PlanetResourceFile, PlanetResource>();
}
