using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class FreelanceJobSchemaMapper
{
    public static FreelanceJobSchema ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.FreelanceJobSchemaFile, FreelanceJobSchema>();
}
