using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class FreelanceJobSchema
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public List<FreelanceJobSchemaEntry> Value { get; set; }
    }

    public class FreelanceJobSchemaEntry
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("contentTags")]
        public List<string> ContentTags { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("maxContributionsPerParticipant")]
        public FreelanceJobSchemaLimit MaxContributionsPerParticipant { get; set; }

        [JsonPropertyName("parameters")]
        public List<FreelanceJobSchemaParameter> Parameters { get; set; }

        [JsonPropertyName("progressDescription")]
        public Dictionary<string, string> ProgressDescription { get; set; }

        [JsonPropertyName("rewardDescription")]
        public Dictionary<string, string> RewardDescription { get; set; }

        [JsonPropertyName("targetDescription")]
        public Dictionary<string, string> TargetDescription { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("contributionMultiplier")]
        public FreelanceJobSchemaContributionMultiplier ContributionMultiplier { get; set; }

        [JsonPropertyName("maxProgressPerContribution")]
        public FreelanceJobSchemaLimit MaxProgressPerContribution { get; set; }
    }

    public class FreelanceJobSchemaLimit
    {
        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("unsetDescription")]
        public Dictionary<string, string> UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaParameter
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("matcher")]
        public FreelanceJobSchemaMatcher Matcher { get; set; }

        [JsonPropertyName("itemDelivery")]
        public FreelanceJobSchemaItemDelivery ItemDelivery { get; set; }

        [JsonPropertyName("inventoryType")]
        public FreelanceJobSchemaInventoryType InventoryType { get; set; }

        [JsonPropertyName("boolean")]
        public FreelanceJobSchemaBooleanParameter Boolean { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("maxEntries")]
        public long? MaxEntries { get; set; }

        [JsonPropertyName("optional")]
        public bool? Optional { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("unsetDescription")]
        public Dictionary<string, string> UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaMatcher
    {
        [JsonPropertyName("acceptedValueTypes")]
        public List<string> AcceptedValueTypes { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("maxEntries")]
        public long? MaxEntries { get; set; }

        [JsonPropertyName("optional")]
        public bool? Optional { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("unsetDescription")]
        public Dictionary<string, string> UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaItemDelivery
    {
        [JsonPropertyName("deliveryLocation")]
        public FreelanceJobSchemaMatcher DeliveryLocation { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("maxEntries")]
        public long? MaxEntries { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("unsetDescription")]
        public Dictionary<string, string> UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaInventoryType
    {
        [JsonPropertyName("acceptedValueTypes")]
        public List<string> AcceptedValueTypes { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("unsetDescription")]
        public Dictionary<string, string> UnsetDescription { get; set; }
    }

    public class FreelanceJobSchemaBooleanParameter
    {
        [JsonPropertyName("choiceLabel")]
        public Dictionary<string, string> ChoiceLabel { get; set; }

        [JsonPropertyName("default")]
        public bool Default { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("optionFalse")]
        public FreelanceJobSchemaBooleanOption OptionFalse { get; set; }

        [JsonPropertyName("optionTrue")]
        public FreelanceJobSchemaBooleanOption OptionTrue { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }
    }

    public class FreelanceJobSchemaBooleanOption
    {
        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }
    }

    public class FreelanceJobSchemaContributionMultiplier
    {
        [JsonPropertyName("defaultValue")]
        public double DefaultValue { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("iconID")]
        public string IconID { get; set; }

        [JsonPropertyName("maxValue")]
        public double MaxValue { get; set; }

        [JsonPropertyName("minValue")]
        public double MinValue { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }

        [JsonPropertyName("unsetDescription")]
        public Dictionary<string, string> UnsetDescription { get; set; }
    }
}
