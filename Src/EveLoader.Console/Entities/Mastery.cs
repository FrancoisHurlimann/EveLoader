using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Mastery
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<MasteryLevel> Value { get; set; }
    }

    public class MasteryLevel
    {
        public long Key { get; set; }

        public List<long> Value { get; set; }
    }
}
