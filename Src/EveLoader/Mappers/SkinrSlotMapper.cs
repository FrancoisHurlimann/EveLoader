using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrSlotMapper
{
    public static SkinrSlot ToDbEntity(this Console.StaticDataModels.SkinrSlotFile model)
        => new SkinrSlot
        {
            Key = model.Key,
            AllowedDesignComponentCategories = model.AllowedDesignComponentCategories?.ToList(),
            Category = model.Category,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
