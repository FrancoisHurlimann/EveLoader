using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapStarMapper
{
    public static MapStar ToDbEntity(this Console.StaticDataModels.MapStarFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapStarFile, MapStar>();
}
