using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DungeonMapper
{
    public static EveLoader.Entities.Db.Dungeon ToDbEntity(this EveLoader.Entities.StaticDataModels.Dungeon model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Dungeon, EveLoader.Entities.Db.Dungeon>();
}
