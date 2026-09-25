using System.Linq;
using EveLoaderEntities;
using EveLoader.Console.StaticDataModels;

namespace EveLoader.Mappers;

public static class BlueprintMapper
{
    public static Blueprint ToDbEntity(this Console.StaticDataModels.BlueprintFile model)
    {
        return new Blueprint
        {
            Key = model.Key,
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
            Copying = model.Copying.ToActivity(),
            Invention = model.Invention.ToInvention(),
            Manufacturing = model.Manufacturing.ToManufacturing(),
            ResearchMaterial = model.ResearchMaterial.ToResearchMaterial(),
            ResearchTime = model.ResearchTime.ToResearchTime()
        };
    }

    public static BlueprintCopying ToActivity(this Console.StaticDataModels.BlueprintActivityFile model)
        => model == null ? null : new BlueprintCopying
        {
            Time = model.Time
        };

    public static BlueprintResearchMaterial ToResearchMaterial(this Console.StaticDataModels.BlueprintActivityFile model)
        => model == null ? null : new BlueprintResearchMaterial
        {
            Time = model.Time
        };

    public static BlueprintResearchTime ToResearchTime(this Console.StaticDataModels.BlueprintActivityFile model)
        => model == null ? null : new BlueprintResearchTime
        {
            Time = model.Time
        };


    public static EveLoaderEntities.BlueprintManufacturing ToManufacturing(this Console.StaticDataModels.BlueprintManufacturing model)
        => model == null ? null : new EveLoaderEntities.BlueprintManufacturing
        {
            Time = model.Time,
            Materials = model.Materials?.Select(m => new EveLoaderEntities.BlueprintManufacturingMaterial
            {
                Quantity = m.Quantity,
                TypeID = m.TypeID
            }).ToList(),
            Products = model.Products?.Select(p => new EveLoaderEntities.BlueprintManufacturingProduct
            {
                Quantity = p.Quantity,
                TypeID = p.TypeID
            }).ToList(),
            Skills = model.Skills?.Select(s => new EveLoaderEntities.BlueprintManufacturingSkill
            {
                Level = s.Level,
                TypeID = s.TypeID
            }).ToList()
        };

    public static EveLoaderEntities.BlueprintInvention ToInvention(this Console.StaticDataModels.BlueprintInvention model)
        => model == null ? null : new EveLoaderEntities.BlueprintInvention
        {
            Time = model.Time,
            Materials = model.Materials?.Select(m => new EveLoaderEntities.BlueprintInventionMaterial
            {
                Quantity = m.Quantity,
                TypeID = m.TypeID
            }).ToList(),
            Products = model.Products?.Select(p => new EveLoaderEntities.BlueprintInventionProduct
            {
                Quantity = p.Quantity,
                TypeID = p.TypeID,
                Probability = p.Probability
            }).ToList(),
            Skills = model.Skills?.Select(s => new EveLoaderEntities.BlueprintInventionSkill
            {
                Level = s.Level,
                TypeID = s.TypeID
            }).ToList()
        };
}
