using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Landmark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string Description { get; set; }

        public long? IconID { get; set; }

        public string Name { get; set; }

        public Position Position { get; set; }
    }

    public class Position
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
    }
}
