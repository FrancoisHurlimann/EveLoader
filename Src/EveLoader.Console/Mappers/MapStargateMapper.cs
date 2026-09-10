using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapStargateMapper
{
    public static MapStargate ToDbEntity(this Console.StaticDataModels.MapStargateFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapStargateFile, MapStargate>();
}
