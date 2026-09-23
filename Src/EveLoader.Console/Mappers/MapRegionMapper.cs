using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapRegionMapper
{
    public static MapRegion ToDbEntity(this Console.StaticDataModels.MapRegionFile model)
        => new MapRegion
        {
            Key = model.Key,
            ConstellationIDs = model.ConstellationIDs?.ToList(),
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            FactionID = model.FactionID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            NebulaID = model.NebulaID,
            Position = model.Position == null
                ? null
                : new Position
                {
                    X = model.Position.X,
                    Y = model.Position.Y,
                    Z = model.Position.Z
                },
            WormholeClassID = model.WormholeClassID
        };
}
