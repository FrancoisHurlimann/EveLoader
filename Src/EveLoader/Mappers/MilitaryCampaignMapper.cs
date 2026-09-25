using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MilitaryCampaignMapper
{
    public static MilitaryCampaign ToDbEntity(this Console.StaticDataModels.MilitaryCampaignFile model)
        => new MilitaryCampaign
        {
            Key = model.Key,
            Annotations = model.Annotations,
            Issuer = model.Issuer == null
                ? null
                : new MilitaryCampaignIssuer
                {
                    CorporationID = model.Issuer.CorporationID,
                    FactionID = model.Issuer.FactionID
                },
            Subtitle = model.Subtitle != null && model.Subtitle.TryGetValue("en", out var subtitle)
                ? subtitle
                : model.Subtitle?.Values.FirstOrDefault(),
            TargetProgress = model.TargetProgress,
            Title = model.Title != null && model.Title.TryGetValue("en", out var title)
                ? title
                : model.Title?.Values.FirstOrDefault()
        };
}
