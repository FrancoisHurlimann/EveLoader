using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class GraphicMaterialSetMapper
{
    public static GraphicMaterialSet ToDbEntity(this Console.StaticDataModels.GraphicMaterialSetFile model)
        => new GraphicMaterialSet
        {
            Key = model.Key,
            ColorHull = model.ColorHull.ToDbColor(),
            ColorPrimary = model.ColorPrimary.ToDbColor(),
            ColorSecondary = model.ColorSecondary.ToDbColor(),
            ColorWindow = model.ColorWindow.ToDbColor(),
            Description = model.Description,
            SofFactionName = model.SofFactionName,
            SofRaceHint = model.SofRaceHint
        };

    private static Color ToDbColor(this Console.StaticDataModels.Color color)
        => color == null
            ? null
            : new Color
            {
                A = color.A,
                B = color.B,
                G = color.G,
                R = color.R
            };
}
