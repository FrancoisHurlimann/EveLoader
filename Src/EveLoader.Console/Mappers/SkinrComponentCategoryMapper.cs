using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinrComponentCategoryMapper
{
    public static SkinrComponentCategory ToDbEntity(this Console.StaticDataModels.SkinrComponentCategoryFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinrComponentCategoryFile, SkinrComponentCategory>();
}
