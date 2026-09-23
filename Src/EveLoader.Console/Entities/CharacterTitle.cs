using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class CharacterTitle
    {
        [Key]
        public int id { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }
    }
}
