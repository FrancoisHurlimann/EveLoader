using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class MercenaryTacticalOperation
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long AnarchyImpact { get; set; }

        public string Description { get; set; }

        public long DevelopmentImpact { get; set; }

        public long DungeonID { get; set; }

        public long InfomorphBonus { get; set; }

        public string Name { get; set; }
    }
}
