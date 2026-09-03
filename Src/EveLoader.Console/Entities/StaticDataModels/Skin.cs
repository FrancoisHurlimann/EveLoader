using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class Skin
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("allowCCPDevs")]
        public bool AllowCCPDevs { get; set; }

        [JsonPropertyName("internalName")]
        public string InternalName { get; set; }

        [JsonPropertyName("skinMaterialID")]
        public long SkinMaterialID { get; set; }

        [JsonPropertyName("types")]
        public List<long> Types { get; set; }

        [JsonPropertyName("visibleSerenity")]
        public bool VisibleSerenity { get; set; }

        [JsonPropertyName("visibleTranquility")]
        public bool VisibleTranquility { get; set; }
    }
}
