using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class CompressibleType
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long CompressedTypeID { get; set; }
    }
}
