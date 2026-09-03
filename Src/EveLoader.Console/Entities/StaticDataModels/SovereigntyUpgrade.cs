using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class SovereigntyUpgrade
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("fuel")]
        public SovereigntyUpgradeFuel Fuel { get; set; }

        [JsonPropertyName("mutually_exclusive_group")]
        public string MutuallyExclusiveGroup { get; set; }

        [JsonPropertyName("power_allocation")]
        public long PowerAllocation { get; set; }

        [JsonPropertyName("workforce_allocation")]
        public long WorkforceAllocation { get; set; }
    }

    public class SovereigntyUpgradeFuel
    {
        [JsonPropertyName("hourly_upkeep")]
        public long HourlyUpkeep { get; set; }

        [JsonPropertyName("startup_cost")]
        public long StartupCost { get; set; }

        [JsonPropertyName("type_id")]
        public long TypeID { get; set; }
    }
}
