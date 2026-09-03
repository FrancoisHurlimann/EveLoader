using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrSlotConfigurationMapper
{
    public static EveLoader.Entities.Db.SkinrSlotConfiguration ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrSlotConfiguration model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrSlotConfiguration, EveLoader.Entities.Db.SkinrSlotConfiguration>();
}
