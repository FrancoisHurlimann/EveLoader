using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class StationServiceMapper
{
    public static StationService ToDbEntity(this Console.StaticDataModels.StationServiceFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.StationServiceFile, StationService>();
}
