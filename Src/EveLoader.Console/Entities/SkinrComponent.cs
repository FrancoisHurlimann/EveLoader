using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class SkinrComponent
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("associatedTypeIds")]
        public List<SkinrComponentAssociatedType> AssociatedTypeIds { get; set; }

        [JsonPropertyName("category")]
        public long Category { get; set; }

        [JsonPropertyName("finish")]
        public string Finish { get; set; }

        [JsonPropertyName("iconFile")]
        public string IconFile { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("projectionTypeU")]
        public string ProjectionTypeU { get; set; }

        [JsonPropertyName("projectionTypeV")]
        public string ProjectionTypeV { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonPropertyName("rarity")]
        public long Rarity { get; set; }

        [JsonPropertyName("resourceFile")]
        public string ResourceFile { get; set; }

        [JsonPropertyName("sequenceBinder")]
        public SkinrComponentSequenceBinder SequenceBinder { get; set; }
    }

    public class SkinrComponentAssociatedType
    {
        [JsonPropertyName("licenseUsesGranted")]
        public long LicenseUsesGranted { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }

    public class SkinrComponentSequenceBinder
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("itemTypeID")]
        public long ItemTypeID { get; set; }
    }
}
