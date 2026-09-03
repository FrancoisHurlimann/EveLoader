using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class FreelanceJobSchemaMapper
{
    public static EveLoader.Entities.Db.FreelanceJobSchema ToDbEntity(this EveLoader.Entities.StaticDataModels.FreelanceJobSchema model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.FreelanceJobSchema, EveLoader.Entities.Db.FreelanceJobSchema>();
}
