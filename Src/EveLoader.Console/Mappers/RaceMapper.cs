using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class RaceMapper
{
    public static Race ToDbEntity(this Console.StaticDataModels.RaceFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.RaceFile, Race>();
}
