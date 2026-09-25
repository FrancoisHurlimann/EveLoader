using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace EveLoaderEntities
{
    public class MilitaryCampaignObjective
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public JsonElement Annotations { get; set; }

        public string CampaignID { get; set; }

        public string CareerPath { get; set; }

        public List<string> ContentTags { get; set; }

        public MilitaryCampaignObjectiveContributionMethodConfiguration ContributionMethodConfiguration { get; set; }

        public MilitaryCampaignObjectiveIssuer Issuer { get; set; }

        public long MaxProgressPerParticipant { get; set; }

        public long PresentingCharacterID { get; set; }

        public MilitaryCampaignObjectiveRewards Rewards { get; set; }

        public string Subtitle { get; set; }

        public long TargetProgress { get; set; }

        public string Title { get; set; }
    }

    public class MilitaryCampaignObjectiveContributionMethodConfiguration
    {
        public string Name { get; set; }

        public List<MilitaryCampaignObjectiveParameter> Parameters { get; set; }
    }

    public class MilitaryCampaignObjectiveParameter
    {
        public string Key { get; set; }

        public MilitaryCampaignObjectiveMatcher Matcher { get; set; }
    }

    public class MilitaryCampaignObjectiveMatcher
    {
        public List<MilitaryCampaignObjectiveMatcherValue> Values { get; set; }
    }

    public class MilitaryCampaignObjectiveMatcherValue
    {
        public string ValueType { get; set; }

        public List<string> Values { get; set; }
    }

    public class MilitaryCampaignObjectiveIssuer
    {
        public long? CorporationID { get; set; }

        public long? FactionID { get; set; }
    }

    public class MilitaryCampaignObjectiveRewards
    {
        public MilitaryCampaignObjectiveReward Isk { get; set; }

        public MilitaryCampaignObjectiveReward Lp { get; set; }

        public MilitaryCampaignObjectiveStandingReward Standing { get; set; }
    }

    public class MilitaryCampaignObjectiveReward
    {
        public long AmountPerInterval { get; set; }

        public MilitaryCampaignObjectiveRewardIssuer Issuer { get; set; }

        public long ProgressInterval { get; set; }
    }

    public class MilitaryCampaignObjectiveStandingReward
    {
        public double GainPercentPerInterval { get; set; }

        public MilitaryCampaignObjectiveRewardIssuer Issuer { get; set; }

        public long ProgressInterval { get; set; }
    }

    public class MilitaryCampaignObjectiveRewardIssuer
    {
        public long? CorporationID { get; set; }

        public long? FactionID { get; set; }
    }
}
