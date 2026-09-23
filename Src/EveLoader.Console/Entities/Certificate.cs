using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Certificate
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public long GroupID { get; set; }

        public string Name { get; set; }

        public List<CertificateRecommendedFor> RecommendedFor { get; set; }

        public List<CertificateSkillType> SkillTypes { get; set; }
    }

    public class CertificateRecommendedFor
    {
        [Key]
        public int id { get; set; }

        public long RecommendedFor { get; set; }

    }

    public class CertificateSkillType
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long Advanced { get; set; }

        public long Basic { get; set; }

        public long Elite { get; set; }

        public long Improved { get; set; }

        public long Standard { get; set; }
    }
}
