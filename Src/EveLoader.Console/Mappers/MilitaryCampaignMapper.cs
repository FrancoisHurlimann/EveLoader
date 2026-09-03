using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class MilitaryCampaignMapper
{
    public static EveLoader.Entities.Db.MilitaryCampaign ToDbEntity(this EveLoader.Entities.StaticDataModels.MilitaryCampaign model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.MilitaryCampaign, EveLoader.Entities.Db.MilitaryCampaign>();
}
