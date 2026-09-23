using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinMapper
{
    public static Skin ToDbEntity(this Console.StaticDataModels.SkinFile model)
        => new Skin
        {
            Key = model.Key,
            AllowCCPDevs = model.AllowCCPDevs,
            InternalName = model.InternalName,
            SkinMaterialID = model.SkinMaterialID,
            Types = model.Types?.ToList(),
            VisibleSerenity = model.VisibleSerenity,
            VisibleTranquility = model.VisibleTranquility
        };
}
