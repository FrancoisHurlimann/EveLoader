using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class StationOperationMapper
{
    public static StationOperation ToDbEntity(this Console.StaticDataModels.StationOperationFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.StationOperationFile, StationOperation>();
}
