using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Mastery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }
        public List<MasteryLevel> Value { get; set; }
    }

    public class MasteryLevel
    {
        public long Key { get; set; }

        public List<long> Value { get; set; }
    }
}
