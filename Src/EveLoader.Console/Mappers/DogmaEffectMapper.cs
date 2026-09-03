using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DogmaEffectMapper
{
    public static EveLoader.Entities.Db.DogmaEffect ToDbEntity(this EveLoader.Entities.StaticDataModels.DogmaEffect model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.DogmaEffect, EveLoader.Entities.Db.DogmaEffect>();
}
