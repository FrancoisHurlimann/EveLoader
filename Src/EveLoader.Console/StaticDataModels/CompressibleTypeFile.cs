using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class CompressibleTypeFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("compressedTypeID")]
        public long CompressedTypeID { get; set; }
    }
}
