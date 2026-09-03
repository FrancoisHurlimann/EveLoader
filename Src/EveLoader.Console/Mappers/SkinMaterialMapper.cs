using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinMaterialMapper
{
    public static EveLoader.Entities.Db.SkinMaterial ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinMaterial model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinMaterial, EveLoader.Entities.Db.SkinMaterial>();
}
