using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class TypeBonusMapper
{
    public static TypeBonus ToDbEntity(this Console.StaticDataModels.TypeBonusFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.TypeBonusFile, TypeBonus>();
}
