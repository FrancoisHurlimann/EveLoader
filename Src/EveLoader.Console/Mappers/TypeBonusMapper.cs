using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TypeBonusMapper
{
    public static EveLoader.Entities.Db.TypeBonus ToDbEntity(this EveLoader.Entities.StaticDataModels.TypeBonus model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.TypeBonus, EveLoader.Entities.Db.TypeBonus>();
}
