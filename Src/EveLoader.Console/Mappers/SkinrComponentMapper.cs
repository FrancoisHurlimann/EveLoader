using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrComponentMapper
{
    public static EveLoader.Entities.Db.SkinrComponent ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrComponent model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrComponent, EveLoader.Entities.Db.SkinrComponent>();
}
