using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class SkinrComponentCategory
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
