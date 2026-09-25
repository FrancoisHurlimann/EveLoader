using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Bloodline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long Charisma { get; set; }

        public long CorporationID { get; set; }

        public string Description { get; set; }

        public long IconID { get; set; }

        public long Intelligence { get; set; }

        public long Memory { get; set; }

        public string Name { get; set; }

        public long Perception { get; set; }

        public long RaceID { get; set; }

        public long Willpower { get; set; }
    }
}
