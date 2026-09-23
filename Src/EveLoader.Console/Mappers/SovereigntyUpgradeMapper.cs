using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SovereigntyUpgradeMapper
{
    public static SovereigntyUpgrade ToDbEntity(this Console.StaticDataModels.SovereigntyUpgradeFile model)
        => new SovereigntyUpgrade
        {
            Key = model.Key,
            Fuel = model.Fuel == null ? null : new SovereigntyUpgradeFuel
            {
                HourlyUpkeep = model.Fuel.HourlyUpkeep,
                StartupCost = model.Fuel.StartupCost,
                TypeID = model.Fuel.TypeID
            },
            MutuallyExclusiveGroup = model.MutuallyExclusiveGroup,
            PowerAllocation = model.PowerAllocation,
            WorkforceAllocation = model.WorkforceAllocation
        };
}
