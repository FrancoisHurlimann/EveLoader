using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class ShipTreeElementMapper
{
    public static EveLoader.Entities.Db.ShipTreeElement ToDbEntity(this EveLoader.Entities.StaticDataModels.ShipTreeElement model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.ShipTreeElement, EveLoader.Entities.Db.ShipTreeElement>();
}
