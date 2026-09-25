using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class TypeElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<TypeElementEntry> Elements { get; set; }
    }

    public class TypeElementEntry
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
