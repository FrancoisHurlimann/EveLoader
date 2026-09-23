using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CharacterTitleMapper
{
    public static CharacterTitle ToDbEntity(this Console.StaticDataModels.CharacterTitleFile model)
        => new CharacterTitle
        {
            Key = model.Key,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
    