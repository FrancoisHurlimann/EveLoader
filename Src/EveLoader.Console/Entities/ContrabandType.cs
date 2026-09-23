using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class ContrabandType
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("factions")]
        public List<ContrabandFaction> Factions { get; set; }
    }

    public class ContrabandFaction
    {
        [Key]
        public int id { get; set; }

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
