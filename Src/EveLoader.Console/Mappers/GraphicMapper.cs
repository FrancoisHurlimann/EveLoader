using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class GraphicMapper
{
    public static EveLoader.Entities.Db.Graphic ToDbEntity(this EveLoader.Entities.StaticDataModels.Graphic model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Graphic, EveLoader.Entities.Db.Graphic>();
}
