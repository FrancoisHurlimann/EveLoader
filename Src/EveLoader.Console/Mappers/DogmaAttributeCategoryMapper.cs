using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class DogmaAttributeCategoryMapper
{
    public static EveLoader.Entities.Db.DogmaAttributeCategory ToDbEntity(this EveLoader.Entities.StaticDataModels.DogmaAttributeCategory model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.DogmaAttributeCategory, EveLoader.Entities.Db.DogmaAttributeCategory>();
}
