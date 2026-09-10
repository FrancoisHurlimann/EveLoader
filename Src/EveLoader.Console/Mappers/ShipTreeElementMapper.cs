using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class ShipTreeElementMapper
{
    public static ShipTreeElement ToDbEntity(this Console.StaticDataModels.ShipTreeElementFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.ShipTreeElementFile, ShipTreeElement>();
}
