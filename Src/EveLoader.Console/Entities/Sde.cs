using System;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Sde
    {
        [Key]
        public int id { get; set; }

        public string Key { get; set; }

        public long BuildNumber { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
