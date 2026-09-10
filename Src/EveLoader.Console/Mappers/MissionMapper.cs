using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MissionMapper
{
    public static Mission ToDbEntity(this Console.StaticDataModels.MissionFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MissionFile, Mission>();
}
