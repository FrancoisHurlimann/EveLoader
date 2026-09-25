using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrSlotConfigurationMapper
{
    public static SkinrSlotConfiguration ToDbEntity(this Console.StaticDataModels.SkinrSlotConfigurationFile model)
        => new SkinrSlotConfiguration
        {
            Key = model.Key,
            AllowAllShips = model.AllowAllShips,
            Config = model.Config?.ToList(),
            Name = model.Name,
            Priority = model.Priority,
            Ships = model.Ships?.ToList()
        };
}
