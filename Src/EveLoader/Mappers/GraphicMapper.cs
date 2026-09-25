using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class GraphicMapper
{
    public static Graphic ToDbEntity(this Console.StaticDataModels.GraphicFile model)
        => new Graphic
        {
            Key = model.Key,
            GraphicFile = model.GraphicFileName,
            IconFolder = model.IconFolder,
            SofFactionName = model.SofFactionName,
            SofHullName = model.SofHullName,
            SofRaceName = model.SofRaceName
        };
}
