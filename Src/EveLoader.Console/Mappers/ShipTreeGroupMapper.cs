using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class ShipTreeGroupMapper
{
    public static ShipTreeGroup ToDbEntity(this Console.StaticDataModels.ShipTreeGroupFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.ShipTreeGroupFile, ShipTreeGroup>();
}
