using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CertificateMapper
{
    public static Certificate ToDbEntity(this Console.StaticDataModels.CertificateFile model)
        => new Certificate
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            GroupID = model.GroupID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            RecommendedFor = model.RecommendedFor?.Select(r => new EveLoader.Console.Entities.CertificateRecommendedFor
            {
                RecommendedFor = r
            }).ToList(),
            SkillTypes = model.SkillTypes?.Select(s => new EveLoader.Console.Entities.CertificateSkillType
            {
                Key = s.Key,
                Advanced = s.Advanced,
                Basic = s.Basic,
                Elite = s.Elite,
                Improved = s.Improved,
                Standard = s.Standard
            }).ToList()
        };
}
