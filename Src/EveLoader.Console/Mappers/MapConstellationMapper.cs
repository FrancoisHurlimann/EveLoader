using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapConstellationMapper
{
    public static EveLoader.Entities.Db.MapConstellation ToDbEntity(this EveLoader.Entities.StaticDataModels.MapConstellation model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapConstellation, EveLoader.Entities.Db.MapConstellation>();
}
