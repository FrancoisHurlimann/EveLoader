using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Icon
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string IconFile { get; set; }
    }
}
