using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinrSlot
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<long> AllowedDesignComponentCategories { get; set; }

        public long Category { get; set; }

        public string Name { get; set; }
    }
}
