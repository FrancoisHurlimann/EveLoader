using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinrComponentPointValue
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<SkinrComponentPointValueEntry> Value { get; set; }
    }

    public class SkinrComponentPointValueEntry
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
