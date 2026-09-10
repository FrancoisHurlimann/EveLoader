using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CategoryMapper
{
    public static Category ToDbEntity(this Console.StaticDataModels.CategoryFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CategoryFile, Category>();
}
