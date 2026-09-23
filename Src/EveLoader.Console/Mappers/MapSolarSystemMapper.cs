using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MapSolarSystemMapper
{
    public static MapSolarSystem ToDbEntity(this Console.StaticDataModels.MapSolarSystemFile model)
        => new MapSolarSystem
        {
            Key = model.Key,
            Border = model.Border,
            ConstellationID = model.ConstellationID,
            Corridor = model.Corridor,
            Fringe = model.Fringe,
            Hub = model.Hub,
            International = model.International,
            Luminosity = model.Luminosity,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            PlanetIDs = model.PlanetIDs?.ToList(),
            Position = model.Position == null
                ? null
                : new Position
                {
                    X = model.Position.X,
                    Y = model.Position.Y,
                    Z = model.Position.Z
                },
            Position2D = model.Position2D == null
                ? null
                : new Position2D
                {
                    X = model.Position2D.X,
                    Y = model.Position2D.Y
                },
            Radius = model.Radius,
            RegionID = model.RegionID,
            Regional = model.Regional,
            SecurityClass = model.SecurityClass,
            SecurityStatus = model.SecurityStatus,
            StarID = model.StarID,
            StargateIDs = model.StargateIDs?.ToList()
        };
}
