using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DungeonMapper
{
    public static Dungeon ToDbEntity(this Console.StaticDataModels.DungeonFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.DungeonFile, Dungeon>();
}
