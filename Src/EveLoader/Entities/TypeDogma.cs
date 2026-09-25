using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class TypeDogma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<TypeDogmaAttribute> DogmaAttributes { get; set; }
    }

    public class TypeDogmaAttribute
    {
        public long AttributeID { get; set; }

        public double Value { get; set; }
    }
}
