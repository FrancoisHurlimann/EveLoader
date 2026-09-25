using System.Collections.Generic;
using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class FreelanceJobSchemaMapper
{
    public static FreelanceJobSchema ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaFile model)
        => new FreelanceJobSchema
        {
            Key = model.Key,
            Value = model.Value?.Select(v => v.ToDbEntity()).ToList()
        };

    private static FreelanceJobSchemaEntry ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaEntry model)
        => new FreelanceJobSchemaEntry
        {
            Key = model.Key,
            ContentTags = model.ContentTags?.ToList(),
            Description = model.Description.ToEnglish(),
            IconID = model.IconID,
            MaxContributionsPerParticipant = model.MaxContributionsPerParticipant.ToDbEntity(),
            Parameters = model.Parameters?.Select(p => p.ToDbEntity()).ToList(),
            ProgressDescription = model.ProgressDescription.ToEnglish(),
            RewardDescription = model.RewardDescription.ToEnglish(),
            TargetDescription = model.TargetDescription.ToEnglish(),
            Title = model.Title.ToEnglish(),
            ContributionMultiplier = model.ContributionMultiplier.ToDbEntity(),
            MaxProgressPerContribution = model.MaxProgressPerContribution.ToDbEntity()
        };

    private static FreelanceJobSchemaLimit ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaLimit model)
        => model == null
            ? null
            : new FreelanceJobSchemaLimit
            {
                Description = model.Description.ToEnglish(),
                IconID = model.IconID,
                Title = model.Title.ToEnglish(),
                UnsetDescription = model.UnsetDescription.ToEnglish()
            };

    private static FreelanceJobSchemaParameter ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaParameter model)
        => new FreelanceJobSchemaParameter
        {
            Key = model.Key,
            Matcher = model.Matcher.ToDbEntity(),
            ItemDelivery = model.ItemDelivery.ToDbEntity(),
            InventoryType = model.InventoryType.ToDbEntity(),
            Boolean = model.Boolean.ToDbEntity(),
            Description = model.Description.ToEnglish(),
            IconID = model.IconID,
            MaxEntries = model.MaxEntries,
            Optional = model.Optional,
            Title = model.Title.ToEnglish(),
            Type = model.Type,
            UnsetDescription = model.UnsetDescription.ToEnglish()
        };

    private static FreelanceJobSchemaMatcher ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaMatcher model)
        => model == null
            ? null
            : new FreelanceJobSchemaMatcher
            {
                AcceptedValueTypes = model.AcceptedValueTypes?.ToList(),
                Description = model.Description.ToEnglish(),
                IconID = model.IconID,
                MaxEntries = model.MaxEntries,
                Optional = model.Optional,
                Title = model.Title.ToEnglish(),
                Type = model.Type,
                UnsetDescription = model.UnsetDescription.ToEnglish()
            };

    private static FreelanceJobSchemaItemDelivery ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaItemDelivery model)
        => model == null
            ? null
            : new FreelanceJobSchemaItemDelivery
            {
                DeliveryLocation = model.DeliveryLocation.ToDbEntity(),
                IconID = model.IconID,
                MaxEntries = model.MaxEntries,
                Title = model.Title.ToEnglish(),
                UnsetDescription = model.UnsetDescription.ToEnglish()
            };

    private static FreelanceJobSchemaInventoryType ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaInventoryType model)
        => model == null
            ? null
            : new FreelanceJobSchemaInventoryType
            {
                AcceptedValueTypes = model.AcceptedValueTypes?.ToList(),
                Description = model.Description.ToEnglish(),
                IconID = model.IconID,
                Title = model.Title.ToEnglish(),
                UnsetDescription = model.UnsetDescription.ToEnglish()
            };

    private static FreelanceJobSchemaBooleanParameter ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaBooleanParameter model)
        => model == null
            ? null
            : new FreelanceJobSchemaBooleanParameter
            {
                ChoiceLabel = model.ChoiceLabel.ToEnglish(),
                Default = model.Default,
                Description = model.Description.ToEnglish(),
                IconID = model.IconID,
                OptionFalse = model.OptionFalse.ToDbEntity(),
                OptionTrue = model.OptionTrue.ToDbEntity(),
                Title = model.Title.ToEnglish()
            };

    private static FreelanceJobSchemaBooleanOption ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaBooleanOption model)
        => model == null
            ? null
            : new FreelanceJobSchemaBooleanOption
            {
                Description = model.Description.ToEnglish(),
                Title = model.Title.ToEnglish()
            };

    private static FreelanceJobSchemaContributionMultiplier ToDbEntity(this Console.StaticDataModels.FreelanceJobSchemaContributionMultiplier model)
        => model == null
            ? null
            : new FreelanceJobSchemaContributionMultiplier
            {
                DefaultValue = model.DefaultValue,
                Description = model.Description.ToEnglish(),
                IconID = model.IconID,
                MaxValue = model.MaxValue,
                MinValue = model.MinValue,
                Title = model.Title.ToEnglish(),
                UnsetDescription = model.UnsetDescription.ToEnglish()
            };

    private static string ToEnglish(this Dictionary<string, string> dictionary)
        => dictionary != null && dictionary.TryGetValue("en", out var value)
            ? value
            : dictionary?.Values.FirstOrDefault();
}
