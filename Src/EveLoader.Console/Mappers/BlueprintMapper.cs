using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class BlueprintMapper
{
    public static Blueprint ToDbEntity(this Console.StaticDataModels.BlueprintFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.BlueprintFile, Blueprint>();
}
