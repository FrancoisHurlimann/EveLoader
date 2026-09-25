using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class CloneGrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string Name { get; set; }

        public List<CloneGradeSkill> Skills { get; set; }
    }

    public class CloneGradeSkill
    {
        [Key]
        public long Key { get; set; }

        public long Level { get; set; }

        public long TypeID { get; set; }
    }
}
