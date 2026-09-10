using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class RaceFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public long IconID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("shipTypeID")]
        public long? ShipTypeID { get; set; }

        [JsonPropertyName("skills")]
        public List<RaceSkill> Skills { get; set; }
    }

    public class RaceSkill
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }
}
