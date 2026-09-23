using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class StationOperationMapper
{
    public static StationOperation ToDbEntity(this Console.StaticDataModels.StationOperationFile model)
        => new StationOperation
        {
            Key = model.Key,
            ActivityID = model.ActivityID,
            Border = model.Border,
            Corridor = model.Corridor,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            Fringe = model.Fringe,
            Hub = model.Hub,
            ManufacturingFactor = model.ManufacturingFactor,
            OperationName = model.OperationName != null && model.OperationName.TryGetValue("en", out var operationName)
                ? operationName
                : model.OperationName?.Values.FirstOrDefault(),
            Ratio = model.Ratio,
            ResearchFactor = model.ResearchFactor,
            Services = model.Services?.ToList(),
            StationTypes = model.StationTypes?.Select(s => new StationOperationStationType { Key = s.Key, Value = s.Value }).ToList()
        };
}
