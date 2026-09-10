using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MilitaryCampaignObjectiveMapper
{
    public static MilitaryCampaignObjective ToDbEntity(this Console.StaticDataModels.MilitaryCampaignObjectiveFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MilitaryCampaignObjectiveFile, MilitaryCampaignObjective>();
}
