using System.Linq;
using EveLoader.Console.Entities;
using EveLoader.Console.StaticDataModels;

namespace EveLoader.Mappers;

public static class BlueprintMapper
{
    public static Blueprint ToDbEntity(this Console.StaticDataModels.BlueprintFile model)
    {
        return new Blueprint
        {
            Id = model.Key,
            BlueprintTypeID = model.BlueprintTypeID,
            MaxProductionLimit = model.MaxProductionLimit,
            Activities = model.Activities.ToActivities(model.Key)
        };
    }

    public static BlueprintActivities ToActivities(this Console.StaticDataModels.BlueprintActivitiesFile model, long blueprintId)
    {
        if (model == null) return null;

        return new BlueprintActivities
        {
            BlueprintId = blueprintId,
            // map properties; adjust these lines if nested property types differ
            Copying = model.Copying.ToActivity(),
            Manufacturing = model.Manufacturing.ToManufacturing(),
            //Invention = model.Invention.ToInvention(),
            //ResearchMaterial = model.ResearchMaterial.ToActivity(),
            //ResearchTime = model.ResearchTime.ToActivity()
        };
    }

    // Map a simple activity (file -> entity)
    public static BlueprintCopying ToActivity(this Console.StaticDataModels.BlueprintActivityFile model)
        => model == null ? null : new BlueprintCopying
        {
            Time = model.Time
        };

    // Map manufacturing (file -> entity). Currently maps shared/basic fields (Time).
    // Extend mapping for Materials/Products/Skills when you have corresponding entity mappers.
    public static EveLoader.Console.Entities.BlueprintManufacturing ToManufacturing(this Console.StaticDataModels.BlueprintManufacturing model)
        => model == null ? null : new EveLoader.Console.Entities.BlueprintManufacturing
        {
            Time = model.Time
            // Materials = ... (map when corresponding mappers exist)
            // Products = ...
            // Skills = ...
        };

    public static EveLoader.Console.Entities.BlueprintInvention ToInvention(this Console.StaticDataModels.BlueprintInvention model)
        => model == null ? null : new EveLoader.Console.Entities.BlueprintInvention
        {
            Time = model.Time
            // map additional properties when entity mappers are available
        };
}
