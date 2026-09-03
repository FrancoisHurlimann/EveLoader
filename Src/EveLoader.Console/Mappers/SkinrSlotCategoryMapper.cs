using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrSlotCategoryMapper
{
    public static EveLoader.Entities.Db.SkinrSlotCategory ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrSlotCategory model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrSlotCategory, EveLoader.Entities.Db.SkinrSlotCategory>();
}
