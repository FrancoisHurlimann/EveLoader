using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class EpicArcMapper
{
    public static EpicArc ToDbEntity(this Console.StaticDataModels.EpicArcFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.EpicArcFile, EpicArc>();
}
