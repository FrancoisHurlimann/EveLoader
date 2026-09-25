using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class PlanetSchematicMapper
{
    public static PlanetSchematic ToDbEntity(this Console.StaticDataModels.PlanetSchematicFile model)
        => new PlanetSchematic
        {
            Key = model.Key,
            CycleTime = model.CycleTime,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            Pins = model.Pins?.ToList(),
            Types = model.Types?.Select(t => new PlanetSchematicType
            {
                Key = t.Key,
                IsInput = t.IsInput,
                Quantity = t.Quantity
            }).ToList()
        };
}
