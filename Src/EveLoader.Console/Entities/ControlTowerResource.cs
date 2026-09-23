using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class ControlTowerResource
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<ControlTowerResourceItem> Resources { get; set; }
    }

    public class ControlTowerResourceItem
    {
        public long Purpose { get; set; }

        public long Quantity { get; set; }

        public long ResourceTypeID { get; set; }

        public long? FactionID { get; set; }

        public double? MinSecurityLevel { get; set; }
    }
}
