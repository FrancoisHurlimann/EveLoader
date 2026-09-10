using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CharacterAttributeMapper
{
    public static CharacterAttribute ToDbEntity(this Console.StaticDataModels.CharacterAttributeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CharacterAttributeFile, CharacterAttribute>();
}
