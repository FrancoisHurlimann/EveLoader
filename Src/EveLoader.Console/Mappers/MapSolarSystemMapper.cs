using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapSolarSystemMapper
{
    public static MapSolarSystem ToDbEntity(this Console.StaticDataModels.MapSolarSystemFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapSolarSystemFile, MapSolarSystem>();
}
