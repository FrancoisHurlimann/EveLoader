using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinMaterial
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string DisplayName { get; set; }

        public long MaterialSetID { get; set; }
    }
}
