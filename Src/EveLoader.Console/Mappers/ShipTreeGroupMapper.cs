using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class ShipTreeGroupMapper
{
    public static EveLoader.Entities.Db.ShipTreeGroup ToDbEntity(this EveLoader.Entities.StaticDataModels.ShipTreeGroup model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.ShipTreeGroup, EveLoader.Entities.Db.ShipTreeGroup>();
}
