using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapStargateMapper
{
    public static EveLoader.Entities.Db.MapStargate ToDbEntity(this EveLoader.Entities.StaticDataModels.MapStargate model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapStargate, EveLoader.Entities.Db.MapStargate>();
}
