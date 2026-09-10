using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapConstellationMapper
{
    public static MapConstellation ToDbEntity(this Console.StaticDataModels.MapConstellationFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapConstellationFile, MapConstellation>();
}
