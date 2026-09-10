using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapRegionMapper
{
    public static MapRegion ToDbEntity(this Console.StaticDataModels.MapRegionFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapRegionFile, MapRegion>();
}
