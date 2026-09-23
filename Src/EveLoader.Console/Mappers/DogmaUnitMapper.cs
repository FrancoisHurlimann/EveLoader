using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DogmaUnitMapper
{
    public static DogmaUnit ToDbEntity(this Console.StaticDataModels.DogmaUnitFile model)
        => new DogmaUnit
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            DisplayName = model.DisplayName != null && model.DisplayName.TryGetValue("en", out var displayName)
                ? displayName
                : model.DisplayName?.Values.FirstOrDefault(),
            Name = model.Name
        };
}
