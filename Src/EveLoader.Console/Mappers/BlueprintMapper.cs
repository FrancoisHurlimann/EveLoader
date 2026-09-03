using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class BlueprintMapper
{
    public static EveLoader.Entities.Db.Blueprint ToDbEntity(this EveLoader.Entities.StaticDataModels.Blueprint model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Blueprint, EveLoader.Entities.Db.Blueprint>();
}
