using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapPlanetMapper
{
    public static MapPlanet ToDbEntity(this Console.StaticDataModels.MapPlanetFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapPlanetFile, MapPlanet>();
}
