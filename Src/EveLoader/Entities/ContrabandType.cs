using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class ContrabandType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<ContrabandFaction> Factions { get; set; }
    }

    public class ContrabandFaction
    {
        [Key]
        public long Key { get; set; }

        public double AttackMinSec { get; set; }

        public double ConfiscateMinSec { get; set; }

        public double FineByValue { get; set; }

        public double StandingLoss { get; set; }
    }
}
