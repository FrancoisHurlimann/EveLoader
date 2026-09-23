using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Skin
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public bool AllowCCPDevs { get; set; }

        public string InternalName { get; set; }

        public long SkinMaterialID { get; set; }

        public List<long> Types { get; set; }

        public bool VisibleSerenity { get; set; }

        public bool VisibleTranquility { get; set; }
    }
}
