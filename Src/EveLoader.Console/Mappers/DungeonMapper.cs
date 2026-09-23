using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DungeonMapper
{
    public static Dungeon ToDbEntity(this Console.StaticDataModels.DungeonFile model)
        => new Dungeon
        {
            Key = model.Key,
            AllowedShipsList = model.AllowedShipsList?.ToList(),
            ArchetypeID = model.ArchetypeID,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            FactionID = model.FactionID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
