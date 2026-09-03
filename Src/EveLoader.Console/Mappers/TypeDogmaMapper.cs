using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class TypeDogmaMapper
{
    public static EveLoader.Entities.Db.TypeDogma ToDbEntity(this EveLoader.Entities.StaticDataModels.TypeDogma model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.TypeDogma, EveLoader.Entities.Db.TypeDogma>();
}
