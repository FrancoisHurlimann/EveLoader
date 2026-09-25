using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class DogmaAttributeMapper
{
    public static DogmaAttribute ToDbEntity(this Console.StaticDataModels.DogmaAttributeFile model)
        => new DogmaAttribute
        {
            Key = model.Key,
            AttributeCategoryID = model.AttributeCategoryID,
            DataType = model.DataType,
            DefaultValue = model.DefaultValue,
            Description = model.Description,
            DisplayName = model.DisplayName != null && model.DisplayName.TryGetValue("en", out var displayName)
                ? displayName
                : model.DisplayName?.Values.FirstOrDefault(),
            DisplayWhenZero = model.DisplayWhenZero,
            HighIsGood = model.HighIsGood,
            IconID = model.IconID,
            Name = model.Name,
            Published = model.Published,
            Stackable = model.Stackable,
            TooltipDescription = model.TooltipDescription != null && model.TooltipDescription.TryGetValue("en", out var tooltipDescription)
                ? tooltipDescription
                : model.TooltipDescription?.Values.FirstOrDefault(),
            TooltipTitle = model.TooltipTitle != null && model.TooltipTitle.TryGetValue("en", out var tooltipTitle)
                ? tooltipTitle
                : model.TooltipTitle?.Values.FirstOrDefault(),
            UnitID = model.UnitID
        };
}
