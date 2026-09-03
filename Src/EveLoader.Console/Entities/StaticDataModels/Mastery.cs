using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class Mastery
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public List<MasteryLevel> Value { get; set; }
    }

    public class MasteryLevel
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public List<long> Value { get; set; }
    }
}
