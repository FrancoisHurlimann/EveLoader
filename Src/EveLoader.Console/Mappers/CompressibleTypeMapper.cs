using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CompressibleTypeMapper
{
    public static EveLoader.Entities.Db.CompressibleType ToDbEntity(this EveLoader.Entities.StaticDataModels.CompressibleType model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.CompressibleType, EveLoader.Entities.Db.CompressibleType>();
}
