using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CorporationActivityMapper
{
    public static CorporationActivity ToDbEntity(this Console.StaticDataModels.CorporationActivityFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CorporationActivityFile, CorporationActivity>();
}
