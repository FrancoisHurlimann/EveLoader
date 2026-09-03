using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DogmaAttributeMapper
{
    public static EveLoader.Entities.Db.DogmaAttribute ToDbEntity(this EveLoader.Entities.StaticDataModels.DogmaAttribute model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.DogmaAttribute, EveLoader.Entities.Db.DogmaAttribute>();
}
