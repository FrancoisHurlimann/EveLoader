using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinLicenseMapper
{
    public static SkinLicense ToDbEntity(this Console.StaticDataModels.SkinLicenseFile model)
        => new SkinLicense
        {
            Key = model.Key,
            Duration = model.Duration,
            LicenseTypeID = model.LicenseTypeID,
            SkinID = model.SkinID
        };
}
