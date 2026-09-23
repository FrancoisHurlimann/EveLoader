using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class TypeList
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<long> IncludedCategoryIDs { get; set; }

        public List<long> IncludedGroupIDs { get; set; }

        public List<long> IncludedTypeIDs { get; set; }

        public string Name { get; set; }
    }
}
