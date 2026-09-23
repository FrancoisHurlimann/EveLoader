using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class CharacterAttribute
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public long IconID { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public string ShortDescription { get; set; }
    }
}
