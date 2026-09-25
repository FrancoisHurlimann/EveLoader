using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class TranslationLanguageMapper
{
    public static TranslationLanguage ToDbEntity(this Console.StaticDataModels.TranslationLanguageFile model)
        => new TranslationLanguage
        {
            Key = model.Key,
            Name = model.Name
        };
}
