using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DogmaUnitMapper
{
    public static EveLoader.Entities.Db.DogmaUnit ToDbEntity(this EveLoader.Entities.StaticDataModels.DogmaUnit model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.DogmaUnit, EveLoader.Entities.Db.DogmaUnit>();
}
