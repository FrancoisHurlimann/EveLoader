using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class AgentsInSpaceFile
    {
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
