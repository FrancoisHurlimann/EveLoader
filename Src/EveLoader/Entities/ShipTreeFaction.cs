using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class ShipTreeFaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string Description { get; set; }

        public List<ShipTreeFactionElement> Elements { get; set; }

        public string Icon { get; set; }
    }

    public class ShipTreeFactionElement
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
