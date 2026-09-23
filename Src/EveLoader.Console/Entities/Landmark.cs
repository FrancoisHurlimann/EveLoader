using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Landmark
    {
        [Key]
        public int id { get; set; }

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
