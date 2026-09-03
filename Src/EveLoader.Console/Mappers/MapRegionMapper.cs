using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapRegionMapper
{
    public static EveLoader.Entities.Db.MapRegion ToDbEntity(this EveLoader.Entities.StaticDataModels.MapRegion model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapRegion, EveLoader.Entities.Db.MapRegion>();
}
