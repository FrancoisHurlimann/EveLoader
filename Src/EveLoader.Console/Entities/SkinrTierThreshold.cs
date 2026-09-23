using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinrTierThreshold
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<SkinrTierThresholdEntry> Value { get; set; }
    }

    public class SkinrTierThresholdEntry
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
