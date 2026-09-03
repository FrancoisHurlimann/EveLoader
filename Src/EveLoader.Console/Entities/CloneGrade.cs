using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class CloneGrade
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("skills")]
        public List<CloneGradeSkill> Skills { get; set; }
    }

    public class CloneGradeSkill
    {
        [JsonPropertyName("level")]
        public long Level { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
