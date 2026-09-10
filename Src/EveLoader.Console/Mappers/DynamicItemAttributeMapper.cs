using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DynamicItemAttributeMapper
{
    public static DynamicItemAttribute ToDbEntity(this Console.StaticDataModels.DynamicItemAttributeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.DynamicItemAttributeFile, DynamicItemAttribute>();
}
