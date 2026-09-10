using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class NpcCharacterMapper
{
    public static NpcCharacter ToDbEntity(this Console.StaticDataModels.NpcCharacterFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.NpcCharacterFile, NpcCharacter>();
}
