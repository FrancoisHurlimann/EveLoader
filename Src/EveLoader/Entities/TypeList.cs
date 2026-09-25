using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class TypeList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<long> IncludedCategoryIDs { get; set; }

        public List<long> IncludedGroupIDs { get; set; }

        public List<long> IncludedTypeIDs { get; set; }

        public string Name { get; set; }
    }
}
