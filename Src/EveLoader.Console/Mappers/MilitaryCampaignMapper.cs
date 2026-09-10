using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MilitaryCampaignMapper
{
    public static MilitaryCampaign ToDbEntity(this Console.StaticDataModels.MilitaryCampaignFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MilitaryCampaignFile, MilitaryCampaign>();
}
