using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapAsteroidBeltMapper
{
    public static MapAsteroidBelt ToDbEntity(this Console.StaticDataModels.MapAsteroidBeltFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MapAsteroidBeltFile, MapAsteroidBelt>();
}
