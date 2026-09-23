using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class CorporationActivity
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Name { get; set; }
    }
}
