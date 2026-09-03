using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class ContrabandTypeMapper
{
    public static EveLoader.Entities.Db.ContrabandType ToDbEntity(this EveLoader.Entities.StaticDataModels.ContrabandType model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.ContrabandType, EveLoader.Entities.Db.ContrabandType>();
}
