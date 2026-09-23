using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class NpcCorporationDivision
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public string InternalName { get; set; }

        public string LeaderTypeName { get; set; }

        public string Name { get; set; }
    }
}
