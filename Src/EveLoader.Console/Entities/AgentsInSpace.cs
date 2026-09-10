using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class AgentsInSpace
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("dungeonID")]
        public long DungeonID { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("spawnPointID")]
        public long SpawnPointID { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
