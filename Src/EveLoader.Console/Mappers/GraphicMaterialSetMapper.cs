using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class GraphicMaterialSetMapper
{
    public static GraphicMaterialSet ToDbEntity(this Console.StaticDataModels.GraphicMaterialSetFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.GraphicMaterialSetFile, GraphicMaterialSet>();
}
