using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class DogmaAttributeCategory
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}
