using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinMapper
{
    public static EveLoader.Entities.Db.Skin ToDbEntity(this EveLoader.Entities.StaticDataModels.Skin model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Skin, EveLoader.Entities.Db.Skin>();
}
