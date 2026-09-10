using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapSecondarySunMapper
{
    public static MapSecondarySun ToDbEntity(this Console.StaticDataModels.MapSecondarySunFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapSecondarySunFile, MapSecondarySun>();
}
