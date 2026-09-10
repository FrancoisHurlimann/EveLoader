using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class CloneGrade
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("skills")]
        public List<CloneGradeSkill> Skills { get; set; }
    }

    public class CloneGradeSkill
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("level")]
        public long Level { get; set; }

        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
