using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MapStarMapper
{
    public static MapStar ToDbEntity(this Console.StaticDataModels.MapStarFile model)
        => new MapStar
        {
            Key = model.Key,
            Radius = model.Radius,
            SolarSystemID = model.SolarSystemID,
            Age = model.Statistics.Age,
            Life = model.Statistics.Life,
            Luminosity = model.Statistics.Luminosity,
            SpectralClass = model.Statistics.SpectralClass,
            Temperature = model.Statistics.Temperature,
            TypeID = model.TypeID
        };
}
