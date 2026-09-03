using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class SkinLicense
    {
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
