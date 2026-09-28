using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class GraphicMaterialSetMapper
{
    public static GraphicMaterialSet ToDbEntity(this Console.StaticDataModels.GraphicMaterialSetFile model)
        => new GraphicMaterialSet
        {
            Key = model.Key,
            ColorHullA = model.ColorHull?.A ?? 0,
            ColorHullB = model.ColorHull?.B ?? 0,
            ColorHullG = model.ColorHull?.G ?? 0,
            ColorHullR = model.ColorHull?.R ?? 0,
            ColorPrimaryA = model.ColorPrimary?.A ?? 0,
            ColorPrimaryB = model.ColorPrimary?.B ?? 0,
            ColorPrimaryG = model.ColorPrimary?.G ?? 0,
            ColorPrimaryR = model.ColorPrimary?.R ?? 0,
            ColorSecondaryA = model.ColorSecondary?.A ?? 0,
            ColorSecondaryB = model.ColorSecondary?.B ?? 0,
            ColorSecondaryG = model.ColorSecondary?.G ?? 0,
            ColorSecondaryR = model.ColorSecondary?.R ?? 0,
            ColorWindowA = model.ColorWindow?.A ?? 0,
            ColorWindowB = model.ColorWindow?.B ?? 0,
            ColorWindowG = model.ColorWindow?.G ?? 0,
            ColorWindowR = model.ColorWindow?.R ?? 0,
            Description = model.Description,
            SofFactionName = model.SofFactionName,
            SofRaceHint = model.SofRaceHint
        };
}
