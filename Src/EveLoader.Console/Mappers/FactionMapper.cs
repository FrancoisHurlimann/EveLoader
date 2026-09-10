using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class FactionMapper
{
    public static Faction ToDbEntity(this Console.StaticDataModels.FactionFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.FactionFile, Faction>();
}
