using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public bool Anchorable { get; set; }

        public bool Anchored { get; set; }

        public long CategoryID { get; set; }

        public bool FittableNonSingleton { get; set; }

        public long? IconID { get; set; }

        public string Name { get; set; }

        public bool Published { get; set; }

        public bool UseBasePrice { get; set; }
    }
}
