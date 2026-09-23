using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrComponentRarityMapper
{
    public static SkinrComponentRarity ToDbEntity(this Console.StaticDataModels.SkinrComponentRarityFile model)
        => new SkinrComponentRarity
        {
            Key = model.Key,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            Rank = model.Rank
        };
}
