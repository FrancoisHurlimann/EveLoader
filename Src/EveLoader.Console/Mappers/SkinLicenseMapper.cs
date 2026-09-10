using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class SkinLicenseMapper
{
    public static SkinLicense ToDbEntity(this Console.StaticDataModels.SkinLicenseFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.SkinLicenseFile, SkinLicense>();
}
