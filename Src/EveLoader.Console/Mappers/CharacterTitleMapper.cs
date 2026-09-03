using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CharacterTitleMapper
{
    public static EveLoader.Entities.Db.CharacterTitle ToDbEntity(this EveLoader.Entities.StaticDataModels.CharacterTitle model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.CharacterTitle, EveLoader.Entities.Db.CharacterTitle>();
}
