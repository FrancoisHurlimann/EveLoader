using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class TypeMaterial
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<TypeMaterialEntry> Materials { get; set; }
    }

    public class TypeMaterialEntry
    {
        public long MaterialTypeID { get; set; }

        public long Quantity { get; set; }
    }
}
