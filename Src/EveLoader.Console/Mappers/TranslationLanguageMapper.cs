using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TranslationLanguageMapper
{
    public static EveLoader.Entities.Db.TranslationLanguage ToDbEntity(this EveLoader.Entities.StaticDataModels.TranslationLanguage model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.TranslationLanguage, EveLoader.Entities.Db.TranslationLanguage>();
}
