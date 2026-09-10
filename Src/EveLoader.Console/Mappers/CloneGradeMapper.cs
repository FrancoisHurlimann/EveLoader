using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CloneGradeMapper
{
    public static CloneGrade ToDbEntity(this Console.StaticDataModels.CloneGradeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CloneGradeFile, CloneGrade>();
}
