using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class NpcCorporationDivision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public string InternalName { get; set; }

        public string LeaderTypeName { get; set; }

        public string Name { get; set; }
    }
}
