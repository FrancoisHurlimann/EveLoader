using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class GraphicMaterialSetMapper
{
    public static EveLoader.Entities.Db.GraphicMaterialSet ToDbEntity(this EveLoader.Entities.StaticDataModels.GraphicMaterialSet model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.GraphicMaterialSet, EveLoader.Entities.Db.GraphicMaterialSet>();
}
