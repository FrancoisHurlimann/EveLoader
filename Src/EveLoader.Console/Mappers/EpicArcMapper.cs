using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class EpicArcMapper
{
    public static EveLoader.Entities.Db.EpicArc ToDbEntity(this EveLoader.Entities.StaticDataModels.EpicArc model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.EpicArc, EveLoader.Entities.Db.EpicArc>();
}
