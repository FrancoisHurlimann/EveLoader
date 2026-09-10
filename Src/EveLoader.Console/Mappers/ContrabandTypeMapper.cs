using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class ContrabandTypeMapper
{
    public static ContrabandType ToDbEntity(this Console.StaticDataModels.ContrabandTypeFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.ContrabandTypeFile, ContrabandType>();
}
