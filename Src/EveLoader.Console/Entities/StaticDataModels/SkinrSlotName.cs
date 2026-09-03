using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class SkinrSlotName
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
