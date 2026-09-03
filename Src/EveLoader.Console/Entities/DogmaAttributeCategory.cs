using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class DogmaAttributeCategory
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
