using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class ControlTowerResource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }
        public List<ControlTowerResourceItem> Resources { get; set; }
    }

    public class ControlTowerResourceItem
    {
        [Key]
        public long Key { get; set; }

        public long Purpose { get; set; }

        public long Quantity { get; set; }

        public long ResourceTypeID { get; set; }

        public long? FactionID { get; set; }

        public double? MinSecurityLevel { get; set; }
    }
}
