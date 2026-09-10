using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SovereigntyUpgradeMapper
{
    public static SovereigntyUpgrade ToDbEntity(this Console.StaticDataModels.SovereigntyUpgradeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SovereigntyUpgradeFile, SovereigntyUpgrade>();
}
