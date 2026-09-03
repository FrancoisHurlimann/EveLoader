using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class ControlTowerResourceMapper
{
    public static EveLoader.Entities.Db.ControlTowerResource ToDbEntity(this EveLoader.Entities.StaticDataModels.ControlTowerResource model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.ControlTowerResource, EveLoader.Entities.Db.ControlTowerResource>();
}
