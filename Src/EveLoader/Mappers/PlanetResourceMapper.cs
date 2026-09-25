using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class PlanetResourceMapper
{
    public static PlanetResource ToDbEntity(this Console.StaticDataModels.PlanetResourceFile model)
        => new PlanetResource
        {
            Key = model.Key,
            Power = model.Power,
            Workforce = model.Workforce
        };
}
