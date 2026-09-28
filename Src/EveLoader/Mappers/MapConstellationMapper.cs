using System.Linq;
using EveLoaderEntities;

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
            MapConstellationX = model.Position.X,
            MapConstellationY = model.Position.Y,
            MapConstellationZ = model.Position.Z,
            RegionID = model.RegionID,
            SolarSystemIDs = model.SolarSystemIDs?.ToList(),
            WormholeClassID = model.WormholeClassID
        };
}
