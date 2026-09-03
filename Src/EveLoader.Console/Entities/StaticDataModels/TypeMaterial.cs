using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class TypeMaterial
    {
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
