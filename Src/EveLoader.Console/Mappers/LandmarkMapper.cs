using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class LandmarkMapper
{
    public static Landmark ToDbEntity(this Console.StaticDataModels.LandmarkFile model)
        => new Landmark
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            IconID = model.IconID,
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
                }
        };
}
