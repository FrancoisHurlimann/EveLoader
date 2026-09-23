using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SovereigntyUpgrade
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public SovereigntyUpgradeFuel Fuel { get; set; }

        public string MutuallyExclusiveGroup { get; set; }

        public long PowerAllocation { get; set; }

        public long WorkforceAllocation { get; set; }
    }

    public class SovereigntyUpgradeFuel
    {
        public long HourlyUpkeep { get; set; }

        public long StartupCost { get; set; }

        public long TypeID { get; set; }
    }
}
