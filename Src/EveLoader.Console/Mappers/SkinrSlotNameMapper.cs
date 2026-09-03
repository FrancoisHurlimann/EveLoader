using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrSlotNameMapper
{
    public static EveLoader.Entities.Db.SkinrSlotName ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrSlotName model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrSlotName, EveLoader.Entities.Db.SkinrSlotName>();
}
