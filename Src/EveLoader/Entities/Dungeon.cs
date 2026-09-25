using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Dungeon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<long> AllowedShipsList { get; set; }

        public long ArchetypeID { get; set; }

        public string Description { get; set; }

        public long FactionID { get; set; }

        public string Name { get; set; }
    }
}
