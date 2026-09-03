using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class TypeMaterial
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("materials")]
        public List<TypeMaterialEntry> Materials { get; set; }
    }

    public class TypeMaterialEntry
    {
        [JsonPropertyName("materialTypeID")]
        public long MaterialTypeID { get; set; }

        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
