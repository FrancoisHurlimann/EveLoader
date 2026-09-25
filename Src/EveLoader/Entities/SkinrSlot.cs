using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class SkinrSlot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<long> AllowedDesignComponentCategories { get; set; }

        public long Category { get; set; }

        public string Name { get; set; }
    }
}
