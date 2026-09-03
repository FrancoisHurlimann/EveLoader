using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CloneGradeMapper
{
    public static EveLoader.Entities.Db.CloneGrade ToDbEntity(this EveLoader.Entities.StaticDataModels.CloneGrade model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.CloneGrade, EveLoader.Entities.Db.CloneGrade>();
}
