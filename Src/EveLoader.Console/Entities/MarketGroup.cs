using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class MarketGroup
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public bool HasTypes { get; set; }

        public long IconID { get; set; }

        public string Name { get; set; }

        public long? ParentGroupID { get; set; }
    }
}
