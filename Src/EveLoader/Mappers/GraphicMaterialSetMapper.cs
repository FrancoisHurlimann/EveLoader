using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class GraphicMaterialSetMapper
{
    public static GraphicMaterialSet ToDbEntity(this Console.StaticDataModels.GraphicMaterialSetFile model)
        => new GraphicMaterialSet
        {
            Key = model.Key,
            ColorHull = model.ColorHull.ToDbColor(model.Key * 10 + 1),
            ColorPrimary = model.ColorPrimary.ToDbColor(model.Key * 10 + 2),
            ColorSecondary = model.ColorSecondary.ToDbColor(model.Key * 10 + 3),
            ColorWindow = model.ColorWindow.ToDbColor(model.Key * 10 + 4),
            Description = model.Description,
            SofFactionName = model.SofFactionName,
            SofRaceHint = model.SofRaceHint
        };

    private static Color ToDbColor(this Console.StaticDataModels.Color color, long key)
        => color == null
            ? null
            : new Color
            {
                Key = key,
                A = color.A,
                B = color.B,
                G = color.G,
                R = color.R
            };
}
