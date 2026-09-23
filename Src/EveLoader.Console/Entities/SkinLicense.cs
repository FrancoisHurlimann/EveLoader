using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class SkinLicense
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        [JsonPropertyName("licenseTypeID")]
        public long LicenseTypeID { get; set; }

        [JsonPropertyName("skinID")]
        public long SkinID { get; set; }
    }
}
