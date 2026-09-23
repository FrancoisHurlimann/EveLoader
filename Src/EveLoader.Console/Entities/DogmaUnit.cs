using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class DogmaUnit
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public string Name { get; set; }
    }
}
