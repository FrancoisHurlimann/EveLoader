using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class NpcCharacterMapper
{
    public static EveLoader.Entities.Db.NpcCharacter ToDbEntity(this EveLoader.Entities.StaticDataModels.NpcCharacter model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.NpcCharacter, EveLoader.Entities.Db.NpcCharacter>();
}
