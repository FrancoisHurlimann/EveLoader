using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class TranslationLanguageMapper
{
    public static TranslationLanguage ToDbEntity(this Console.StaticDataModels.TranslationLanguageFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TranslationLanguageFile, TranslationLanguage>();
}
