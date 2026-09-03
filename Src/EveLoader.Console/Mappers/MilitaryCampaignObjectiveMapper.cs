using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MilitaryCampaignObjectiveMapper
{
    public static EveLoader.Entities.Db.MilitaryCampaignObjective ToDbEntity(this EveLoader.Entities.StaticDataModels.MilitaryCampaignObjective model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MilitaryCampaignObjective, EveLoader.Entities.Db.MilitaryCampaignObjective>();
}
