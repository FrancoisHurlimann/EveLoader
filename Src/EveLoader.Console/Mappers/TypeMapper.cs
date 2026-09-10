namespace EveLoader.Mappers;

public static class TypeMapper
{
    public static Console.Entities.Type ToDbEntity(this Console.StaticDataModels.TypeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TypeFile, Console.Entities.Type>();
}
