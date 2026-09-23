using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Ancestry
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long BloodlineID { get; set; }

        public long Charisma { get; set; }

        public string Description { get; set; }

        public long IconID { get; set; }

        public long Intelligence { get; set; }

        public long Memory { get; set; }

        public string Name { get; set; }

        public long Perception { get; set; }

        public string? ShortDescription { get; set; }

        public long Willpower { get; set; }
    }
}
