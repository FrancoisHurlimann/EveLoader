using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class NpcCorporationDivision
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("internalName")]
        public string InternalName { get; set; }

        [JsonPropertyName("leaderTypeName")]
        public Dictionary<string, string> LeaderTypeName { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }
    }
}
