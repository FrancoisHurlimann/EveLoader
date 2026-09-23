using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class TypeElement
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<TypeElementEntry> Elements { get; set; }
    }

    public class TypeElementEntry
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
