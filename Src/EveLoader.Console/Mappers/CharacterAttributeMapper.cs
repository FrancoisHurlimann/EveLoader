using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CharacterAttributeMapper
{
    public static EveLoader.Entities.Db.CharacterAttribute ToDbEntity(this EveLoader.Entities.StaticDataModels.CharacterAttribute model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.CharacterAttribute, EveLoader.Entities.Db.CharacterAttribute>();
}
