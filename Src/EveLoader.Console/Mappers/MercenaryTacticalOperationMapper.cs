using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MercenaryTacticalOperationMapper
{
    public static MercenaryTacticalOperation ToDbEntity(this Console.StaticDataModels.MercenaryTacticalOperationFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MercenaryTacticalOperationFile, MercenaryTacticalOperation>();
}
