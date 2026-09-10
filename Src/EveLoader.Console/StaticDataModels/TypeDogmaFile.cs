using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class TypeDogmaFile
    {
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
