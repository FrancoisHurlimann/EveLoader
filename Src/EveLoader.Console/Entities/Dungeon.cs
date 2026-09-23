using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Dungeon
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<long> AllowedShipsList { get; set; }

        public long ArchetypeID { get; set; }

        public string Description { get; set; }

        public long FactionID { get; set; }

        public string Name { get; set; }
    }
}
