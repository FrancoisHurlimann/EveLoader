using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }
        public bool HasStandingRewards { get; set; }

        public long DungeonID { get; set; }

        public long ObjectiveQuantity { get; set; }

        public string? Message { get; set; }

        public string Name { get; set; }
    }

 

 
}
