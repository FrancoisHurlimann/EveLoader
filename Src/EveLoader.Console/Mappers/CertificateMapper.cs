using EveLoader.Entities.Db;
using EveLoader.Entities.StaticDataModels;

namespace EveLoader.Mappers;

public static class CertificateMapper
{
    public static EveLoader.Entities.Db.Certificate ToDbEntity(this EveLoader.Entities.StaticDataModels.Certificate model)
        => model.ToDbEntityViaJson<EveLoader.Entities.StaticDataModels.Certificate, EveLoader.Entities.Db.Certificate>();
}
