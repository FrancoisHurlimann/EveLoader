using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class ShipTreeFactionMapper
{
    public static ShipTreeFaction ToDbEntity(this Console.StaticDataModels.ShipTreeFactionFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.ShipTreeFactionFile, ShipTreeFaction>();
}
