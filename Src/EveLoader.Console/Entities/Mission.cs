using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class Mission
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("hasStandingRewards")]
        public bool HasStandingRewards { get; set; }

        [JsonPropertyName("killMission")]
        public MissionKillMission KillMission { get; set; }

        [JsonPropertyName("messages")]
        public List<MissionMessage> Messages { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class MissionKillMission
    {
        [JsonPropertyName("dungeonID")]
        public long DungeonID { get; set; }

        [JsonPropertyName("objectiveQuantity")]
        public long ObjectiveQuantity { get; set; }
    }

    public class MissionMessage
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("de")]
        public string De { get; set; }

        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("es")]
        public string Es { get; set; }

        [JsonPropertyName("fr")]
        public string Fr { get; set; }

        [JsonPropertyName("ja")]
        public string Ja { get; set; }

        [JsonPropertyName("ko")]
        public string Ko { get; set; }

        [JsonPropertyName("ru")]
        public string Ru { get; set; }

        [JsonPropertyName("zh")]
        public string Zh { get; set; }
    }
}
