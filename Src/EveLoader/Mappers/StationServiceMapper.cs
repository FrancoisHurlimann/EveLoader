using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class StationServiceMapper
{
    public static StationService ToDbEntity(this Console.StaticDataModels.StationServiceFile model)
        => new StationService
        {
            Key = model.Key,
            ServiceName = model.ServiceName != null && model.ServiceName.TryGetValue("en", out var serviceName)
                ? serviceName
                : model.ServiceName?.Values.FirstOrDefault()
        };
}
