using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrComponentRarityMapper
{
    public static SkinrComponentRarity ToDbEntity(this Console.StaticDataModels.SkinrComponentRarityFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrComponentRarityFile, SkinrComponentRarity>();
}
