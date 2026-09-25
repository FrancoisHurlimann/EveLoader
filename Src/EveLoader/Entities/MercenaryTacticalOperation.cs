using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MercenaryTacticalOperation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long AnarchyImpact { get; set; }

        public string Description { get; set; }

        public long DevelopmentImpact { get; set; }

        public long DungeonID { get; set; }

        public long InfomorphBonus { get; set; }

        public string Name { get; set; }
    }
}
