using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class ContrabandType
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("factions")]
        public List<ContrabandFaction> Factions { get; set; }
    }

    public class ContrabandFaction
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("attackMinSec")]
        public double AttackMinSec { get; set; }

        [JsonPropertyName("confiscateMinSec")]
        public double ConfiscateMinSec { get; set; }

        [JsonPropertyName("fineByValue")]
        public double FineByValue { get; set; }

        [JsonPropertyName("standingLoss")]
        public double StandingLoss { get; set; }
    }
}
