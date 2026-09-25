using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class CorporationActivityMapper
{
    public static CorporationActivity ToDbEntity(this Console.StaticDataModels.CorporationActivityFile model)
        => new CorporationActivity
        {
            Key = model.Key,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
