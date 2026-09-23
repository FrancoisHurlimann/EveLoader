using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class EpicArc
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("arcRestartInterval")]
        public long ArcRestartInterval { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }

        [JsonPropertyName("iconID")]
        public long IconID { get; set; }

        [JsonPropertyName("missions")]
        public List<EpicArcMission> Missions { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class EpicArcMission
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("agentID")]
        public long AgentID { get; set; }

        [JsonPropertyName("failMissionID")]
        public long? FailMissionID { get; set; }

        [JsonPropertyName("nextMissions")]
        public List<long> NextMissions { get; set; }
    }
}
