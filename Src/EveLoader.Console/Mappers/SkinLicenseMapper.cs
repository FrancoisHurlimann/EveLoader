using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class SkinLicenseMapper
{
    public static EveLoader.Entities.Db.SkinLicense ToDbEntity(this EveLoader.Entities.StaticDataModels.SkinLicense model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.SkinLicense, EveLoader.Entities.Db.SkinLicense>();
}
