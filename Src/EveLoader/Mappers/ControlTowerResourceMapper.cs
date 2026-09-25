using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class ControlTowerResourceMapper
{
    public static ControlTowerResource ToDbEntity(this Console.StaticDataModels.ControlTowerResourceFile model)
        => new ControlTowerResource
        {
            Key = model.Key,
            Resources = model.Resources?.Select(r => new ControlTowerResourceItem
            {
                Purpose = r.Purpose,
                Quantity = r.Quantity,
                ResourceTypeID = r.ResourceTypeID,
                FactionID = r.FactionID,
                MinSecurityLevel = r.MinSecurityLevel
            }).ToList()
        };
}
