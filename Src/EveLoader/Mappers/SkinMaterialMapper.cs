using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinMaterialMapper
{
    public static SkinMaterial ToDbEntity(this Console.StaticDataModels.SkinMaterialFile model)
        => new SkinMaterial
        {
            Key = model.Key,
            DisplayName = model.DisplayName != null && model.DisplayName.TryGetValue("en", out var displayName)
                ? displayName
                : model.DisplayName?.Values.FirstOrDefault(),
            MaterialSetID = model.MaterialSetID
        };
}
