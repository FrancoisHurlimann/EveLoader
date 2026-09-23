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


    public static EveLoader.Console.Entities.BlueprintManufacturing ToManufacturing(this Console.StaticDataModels.BlueprintManufacturing model)
        => model == null ? null : new EveLoader.Console.Entities.BlueprintManufacturing
        {
            Time = model.Time,
            Materials = model.Materials?.Select(m => new EveLoader.Console.Entities.BlueprintManufacturingMaterial
            {
                Quantity = m.Quantity,
                TypeID = m.TypeID
            }).ToList(),
            Products = model.Products?.Select(p => new EveLoader.Console.Entities.BlueprintManufacturingProduct
            {
                Quantity = p.Quantity,
                TypeID = p.TypeID,
                Probability = p.Probability 
            }).ToList(),
            Skills = model.Skills?.Select(s => new EveLoader.Console.Entities.BlueprintManufacturingSkill
            {
                Level = s.Level,
                TypeID = s.TypeID
            }).ToList()
        };

    public static EveLoader.Console.Entities.BlueprintInvention ToInvention(this Console.StaticDataModels.BlueprintInvention model)
        => model == null ? null : new EveLoader.Console.Entities.BlueprintInvention
        {
            Time = model.Time,
            Materials = model.Materials?.Select(m => new EveLoader.Console.Entities.BlueprintInventionMaterial
            {
                Quantity = m.Quantity,
                TypeID = m.TypeID
            }).ToList(),
            Products = model.Products?.Select(p => new EveLoader.Console.Entities.BlueprintInventionProduct
            {
                Quantity = p.Quantity,
                TypeID = p.TypeID,
                Probability = p.Probability
            }).ToList(),
            Skills = model.Skills?.Select(s => new EveLoader.Console.Entities.BlueprintInventionSkill
            {
                Level = s.Level,
                TypeID = s.TypeID
            }).ToList()
        };
}
