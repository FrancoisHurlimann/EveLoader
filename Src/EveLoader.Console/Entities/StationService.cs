using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class StationService
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string ServiceName { get; set; }
    }
}
