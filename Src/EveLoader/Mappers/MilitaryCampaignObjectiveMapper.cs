using System.Collections.Generic;
using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MilitaryCampaignObjectiveMapper
{
    public static MilitaryCampaignObjective ToDbEntity(this Console.StaticDataModels.MilitaryCampaignObjectiveFile model)
        => new MilitaryCampaignObjective
        {
            Key = model.Key,
            Annotations = model.Annotations,
            CampaignID = model.CampaignID,
            CareerPath = model.CareerPath,
            ContentTags = model.ContentTags?.ToList(),
            ContributionMethodConfiguration = model.ContributionMethodConfiguration.ToDbEntity(),
            Issuer = model.Issuer == null
                ? null
                : new MilitaryCampaignObjectiveIssuer
                {
                    CorporationID = model.Issuer.CorporationID,
                    FactionID = model.Issuer.FactionID
                },
            MaxProgressPerParticipant = model.MaxProgressPerParticipant,
            PresentingCharacterID = model.PresentingCharacterID,
            Rewards = model.Rewards.ToDbEntity(),
            Subtitle = model.Subtitle.ToEnglish(),
            TargetProgress = model.TargetProgress,
            Title = model.Title.ToEnglish()
        };

    private static MilitaryCampaignObjectiveContributionMethodConfiguration ToDbEntity(this Console.StaticDataModels.MilitaryCampaignObjectiveContributionMethodConfiguration model)
        => model == null
            ? null
            : new MilitaryCampaignObjectiveContributionMethodConfiguration
            {
                Name = model.Name,
                Parameters = model.Parameters?.Select(p => new MilitaryCampaignObjectiveParameter
                {
                    Key = p.Key,
                    Matcher = p.Matcher == null
                        ? null
                        : new MilitaryCampaignObjectiveMatcher
                        {
                            Values = p.Matcher.Values?.Select(v => new MilitaryCampaignObjectiveMatcherValue
                            {
                                ValueType = v.ValueType,
                                Values = v.Values?.ToList()
                            }).ToList()
                        }
                }).ToList()
            };

    private static MilitaryCampaignObjectiveRewards ToDbEntity(this Console.StaticDataModels.MilitaryCampaignObjectiveRewards model)
        => model == null
            ? null
            : new MilitaryCampaignObjectiveRewards
            {
                Isk = model.Isk.ToDbEntity(),
                Lp = model.Lp.ToDbEntity(),
                Standing = model.Standing == null
                    ? null
                    : new MilitaryCampaignObjectiveStandingReward
                    {
                        GainPercentPerInterval = model.Standing.GainPercentPerInterval,
                        Issuer = model.Standing.Issuer.ToDbEntity(),
                        ProgressInterval = model.Standing.ProgressInterval
                    }
            };

    private static MilitaryCampaignObjectiveReward ToDbEntity(this Console.StaticDataModels.MilitaryCampaignObjectiveReward model)
        => model == null
            ? null
            : new MilitaryCampaignObjectiveReward
            {
                AmountPerInterval = model.AmountPerInterval,
                Issuer = model.Issuer.ToDbEntity(),
                ProgressInterval = model.ProgressInterval
            };

    private static MilitaryCampaignObjectiveRewardIssuer ToDbEntity(this Console.StaticDataModels.MilitaryCampaignObjectiveRewardIssuer model)
        => model == null
            ? null
            : new MilitaryCampaignObjectiveRewardIssuer
            {
                CorporationID = model.CorporationID,
                FactionID = model.FactionID
            };

    private static string ToEnglish(this Dictionary<string, string> dictionary)
        => dictionary != null && dictionary.TryGetValue("en", out var value)
            ? value
            : dictionary?.Values.FirstOrDefault();
}
