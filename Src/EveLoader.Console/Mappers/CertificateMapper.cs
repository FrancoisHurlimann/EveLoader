using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class CertificateMapper
{
    public static Certificate ToDbEntity(this Console.StaticDataModels.CertificateFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.CertificateFile, Certificate>();
}
