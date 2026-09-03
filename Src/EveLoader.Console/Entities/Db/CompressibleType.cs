using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class CompressibleType
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("compressedTypeID")]
        public long CompressedTypeID { get; set; }
    }
}
