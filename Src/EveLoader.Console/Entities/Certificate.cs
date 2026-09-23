using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class Certificate
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("groupID")]
        public long GroupID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("recommendedFor")]
        public List<CertificateRecommendedFor> RecommendedFor { get; set; }

        [JsonPropertyName("skillTypes")]
        public List<CertificateSkillType> SkillTypes { get; set; }
    }

    public class CertificateRecommendedFor
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("recommendedFor")]
        public long RecommendedFor { get; set; }

    }

    public class CertificateSkillType
    {
        [Key]
        public int id { get; set; }

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
