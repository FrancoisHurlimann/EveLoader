using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CharacterTitleMapper
{
    public static CharacterTitle ToDbEntity(this Console.StaticDataModels.CharacterTitleFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CharacterTitleFile, CharacterTitle>();
}
