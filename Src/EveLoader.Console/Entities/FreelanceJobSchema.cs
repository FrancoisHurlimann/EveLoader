using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class FreelanceJobSchema
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<FreelanceJobSchemaEntry> Value { get; set; }
    }

    public class FreelanceJobSchemaEntry
    {
        [Key]
        public int id { get; set; }

        public string Key { get; set; }

        public List<string> ContentTags { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public FreelanceJobSchemaLimit MaxContributionsPerParticipant { get; set; }

        public List<FreelanceJobSchemaParameter> Parameters { get; set; }

        public string ProgressDescription { get; set; }

        public string RewardDescription { get; set; }

        public string TargetDescription { get; set; }

        public string Title { get; set; }

        public FreelanceJobSchemaContributionMultiplier ContributionMultiplier { get; set; }

        public FreelanceJobSchemaLimit MaxProgressPerContribution { get; set; }
    }

    public class FreelanceJobSchemaLimit
    {
        [Key]
        public int id { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public string Title { get; set; }

        public string UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaParameter
    {
        [Key]
        public int id { get; set; }

        public string Key { get; set; }

        public FreelanceJobSchemaMatcher Matcher { get; set; }

        public FreelanceJobSchemaItemDelivery ItemDelivery { get; set; }

        public FreelanceJobSchemaInventoryType InventoryType { get; set; }

        public FreelanceJobSchemaBooleanParameter Boolean { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public long? MaxEntries { get; set; }

        public bool? Optional { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaMatcher
    {
        [Key]
        public int id { get; set; }

        public List<string> AcceptedValueTypes { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public long? MaxEntries { get; set; }

        public bool? Optional { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaItemDelivery
    {
        [Key]
        public int id { get; set; }

        public FreelanceJobSchemaMatcher DeliveryLocation { get; set; }

        public string IconID { get; set; }

        public long? MaxEntries { get; set; }

        public string Title { get; set; }

        public string UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaInventoryType
    {
        [Key]
        public int id { get; set; }

        public List<string> AcceptedValueTypes { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public string Title { get; set; }

        public string UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaBooleanParameter
    {
        [Key]
        public int id { get; set; }

        public string ChoiceLabel { get; set; }

        public bool Default { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public FreelanceJobSchemaBooleanOption OptionFalse { get; set; }

        public FreelanceJobSchemaBooleanOption OptionTrue { get; set; }

        public string Title { get; set; }
    }

    public class FreelanceJobSchemaBooleanOption
    {
        [Key]
        public int id { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }
    }

    public class FreelanceJobSchemaContributionMultiplier
    {
        [Key]
        public int id { get; set; }

        public double DefaultValue { get; set; }

        public string Description { get; set; }

        public string IconID { get; set; }

        public double MaxValue { get; set; }

        public double MinValue { get; set; }

        public string Title { get; set; }

        public string UnsetDescription { get; set; }
    }
}
