using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class Certificate
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("groupID")]
        public long GroupID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("recommendedFor")]
        public List<long> RecommendedFor { get; set; }

        [JsonPropertyName("skillTypes")]
        public List<CertificateSkillType> SkillTypes { get; set; }
    }

    public class CertificateSkillType
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("advanced")]
        public long Advanced { get; set; }

        [JsonPropertyName("basic")]
        public long Basic { get; set; }

        [JsonPropertyName("elite")]
        public long Elite { get; set; }

        [JsonPropertyName("improved")]
        public long Improved { get; set; }

        [JsonPropertyName("standard")]
        public long Standard { get; set; }
    }
}
