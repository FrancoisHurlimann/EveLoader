using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinrSlotConfiguration
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public bool? AllowAllShips { get; set; }

        public List<long> Config { get; set; }

        public string Name { get; set; }

        public long Priority { get; set; }

        public List<long> Ships { get; set; }
    }
}
