using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class CharacterAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string Description { get; set; }

        public long IconID { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public string ShortDescription { get; set; }
    }
}
