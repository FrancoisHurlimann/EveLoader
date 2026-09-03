using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrSlotMapper
{
    public static EveLoader.Entities.Db.SkinrSlot ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrSlot model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrSlot, EveLoader.Entities.Db.SkinrSlot>();
}
