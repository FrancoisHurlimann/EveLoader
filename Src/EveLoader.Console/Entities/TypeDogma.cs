using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class TypeDogma
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<TypeDogmaAttribute> DogmaAttributes { get; set; }
    }

    public class TypeDogmaAttribute
    {
        public long AttributeID { get; set; }

        public double Value { get; set; }
    }
}
