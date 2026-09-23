using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapConstellationMapper
{
    public static MapConstellation ToDbEntity(this Console.StaticDataModels.MapConstellationFile model)
        => new MapConstellation
        {
            Key = model.Key,
            FactionID = model.FactionID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            Position = model.Position == null
                ? null
                : new Position
                {
                    X = model.Position.X,
                    Y = model.Position.Y,
                    Z = model.Position.Z
                },
            RegionID = model.RegionID,
            SolarSystemIDs = model.SolarSystemIDs?.ToList(),
            WormholeClassID = model.WormholeClassID
        };
}
