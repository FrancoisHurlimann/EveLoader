using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class NpcStationMapper
{
    public static NpcStation ToDbEntity(this Console.StaticDataModels.NpcStationFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.NpcStationFile, NpcStation>();
}
