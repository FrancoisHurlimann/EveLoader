using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CharacterAttributeMapper
{
    public static CharacterAttribute ToDbEntity(this Console.StaticDataModels.CharacterAttributeFile model)
        => new CharacterAttribute
        {
            Key = model.Key,
            Description = model.Description,
            IconID = model.IconID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            Notes = model.Notes,
            ShortDescription = model.ShortDescription
        };
}
