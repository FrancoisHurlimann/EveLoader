using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class MilitaryCampaignObjectiveFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("annotations")]
        public JsonElement Annotations { get; set; }

        [JsonPropertyName("campaignID")]
        public string CampaignID { get; set; }

        [JsonPropertyName("careerPath")]
        public string CareerPath { get; set; }

        [JsonPropertyName("contentTags")]
        public List<string> ContentTags { get; set; }

        [JsonPropertyName("contributionMethodConfiguration")]
        public MilitaryCampaignObjectiveContributionMethodConfiguration ContributionMethodConfiguration { get; set; }

        [JsonPropertyName("issuer")]
        public MilitaryCampaignObjectiveIssuer Issuer { get; set; }

        [JsonPropertyName("maxProgressPerParticipant")]
        public long MaxProgressPerParticipant { get; set; }

        [JsonPropertyName("presentingCharacterID")]
        public long PresentingCharacterID { get; set; }

        [JsonPropertyName("rewards")]
        public MilitaryCampaignObjectiveRewards Rewards { get; set; }

        [JsonPropertyName("subtitle")]
        public Dictionary<string, string> Subtitle { get; set; }

        [JsonPropertyName("targetProgress")]
        public long TargetProgress { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }
    }

    public class MilitaryCampaignObjectiveContributionMethodConfiguration
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("parameters")]
        public List<MilitaryCampaignObjectiveParameter> Parameters { get; set; }
    }

    public class MilitaryCampaignObjectiveParameter
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("matcher")]
        public MilitaryCampaignObjectiveMatcher Matcher { get; set; }
    }

    public class MilitaryCampaignObjectiveMatcher
    {
        [JsonPropertyName("values")]
        public List<MilitaryCampaignObjectiveMatcherValue> Values { get; set; }
    }

    public class MilitaryCampaignObjectiveMatcherValue
    {
        [JsonPropertyName("valueType")]
        public string ValueType { get; set; }

        [JsonPropertyName("values")]
        public List<string> Values { get; set; }
    }

    public class MilitaryCampaignObjectiveIssuer
    {
        [JsonPropertyName("corporationID")]
        public long? CorporationID { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }
    }

    public class MilitaryCampaignObjectiveRewards
    {
        [JsonPropertyName("isk")]
        public MilitaryCampaignObjectiveReward Isk { get; set; }

        [JsonPropertyName("lp")]
        public MilitaryCampaignObjectiveReward Lp { get; set; }

        [JsonPropertyName("standing")]
        public MilitaryCampaignObjectiveStandingReward Standing { get; set; }
    }

    public class MilitaryCampaignObjectiveReward
    {
        [JsonPropertyName("amountPerInterval")]
        public long AmountPerInterval { get; set; }

        [JsonPropertyName("issuer")]
        public MilitaryCampaignObjectiveRewardIssuer Issuer { get; set; }

        [JsonPropertyName("progressInterval")]
        public long ProgressInterval { get; set; }
    }

    public class MilitaryCampaignObjectiveStandingReward
    {
        [JsonPropertyName("gainPercentPerInterval")]
        public double GainPercentPerInterval { get; set; }

        [JsonPropertyName("issuer")]
        public MilitaryCampaignObjectiveRewardIssuer Issuer { get; set; }

        [JsonPropertyName("progressInterval")]
        public long ProgressInterval { get; set; }
    }

    public class MilitaryCampaignObjectiveRewardIssuer
    {
        [JsonPropertyName("corporationID")]
        public long? CorporationID { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }
    }
}
