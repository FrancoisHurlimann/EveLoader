using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TypeMaterialMapper
{
    public static EveLoader.Entities.Db.TypeMaterial ToDbEntity(this EveLoader.Entities.StaticDataModels.TypeMaterial model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.TypeMaterial, EveLoader.Entities.Db.TypeMaterial>();
}
