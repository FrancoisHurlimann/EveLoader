using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MapMoonMapper
{
    public static EveLoader.Entities.Db.MapMoon ToDbEntity(this EveLoader.Entities.StaticDataModels.MapMoon model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MapMoon, EveLoader.Entities.Db.MapMoon>();
}
