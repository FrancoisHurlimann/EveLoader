using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class SkinrTierThreshold
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<SkinrTierThresholdEntry> Value { get; set; }
    }

    public class SkinrTierThresholdEntry
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
