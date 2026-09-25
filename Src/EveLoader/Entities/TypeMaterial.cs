using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class TypeMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<TypeMaterialEntry> Materials { get; set; }
    }

    public class TypeMaterialEntry
    {
        public long MaterialTypeID { get; set; }

        public long Quantity { get; set; }
    }
}
