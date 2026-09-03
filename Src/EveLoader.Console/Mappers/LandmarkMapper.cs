using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class LandmarkMapper
{
    public static EveLoader.Entities.Db.Landmark ToDbEntity(this EveLoader.Entities.StaticDataModels.Landmark model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Landmark, EveLoader.Entities.Db.Landmark>();
}
