using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class CloneGradeMapper
{
    public static CloneGrade ToDbEntity(this Console.StaticDataModels.CloneGradeFile model)
        => new CloneGrade
        {
            Key = model.Key,
            Name = model.Name,
            Skills = model.Skills?.Select(s => new CloneGradeSkill
            {
                Level = s.Level,
                TypeID = s.TypeID
            }).ToList()
        };
}
