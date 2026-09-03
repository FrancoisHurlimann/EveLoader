using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class TypeDogma
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("dogmaAttributes")]
        public List<TypeDogmaAttribute> DogmaAttributes { get; set; }
    }

    public class TypeDogmaAttribute
    {
        [JsonPropertyName("attributeID")]
        public long AttributeID { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
