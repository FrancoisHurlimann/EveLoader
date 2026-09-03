using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinrComponentPointValueMapper
{
    public static EveLoader.Entities.Db.SkinrComponentPointValue ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinrComponentPointValue model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinrComponentPointValue, EveLoader.Entities.Db.SkinrComponentPointValue>();
}
