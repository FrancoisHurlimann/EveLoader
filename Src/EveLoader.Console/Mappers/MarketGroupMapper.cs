using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MarketGroupMapper
{
    public static MarketGroup ToDbEntity(this Console.StaticDataModels.MarketGroupFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MarketGroupFile, MarketGroup>();
}
