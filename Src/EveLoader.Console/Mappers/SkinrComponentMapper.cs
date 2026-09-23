using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class SkinrComponentMapper
{
    public static SkinrComponent ToDbEntity(this Console.StaticDataModels.SkinrComponentFile model)
        => new SkinrComponent
        {
            Key = model.Key,
            AssociatedTypeIds = model.AssociatedTypeIds?.Select(a => new SkinrComponentAssociatedType
            {
                LicenseUsesGranted = a.LicenseUsesGranted,
                TypeID = a.TypeID
            }).ToList(),
            Category = model.Category,
            Finish = model.Finish,
            IconFile = model.IconFile,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            ProjectionTypeU = model.ProjectionTypeU,
            ProjectionTypeV = model.ProjectionTypeV,
            Published = model.Published,
            Rarity = model.Rarity,
            ResourceFile = model.ResourceFile,
            SequenceBinder = model.SequenceBinder == null ? null : new SkinrComponentSequenceBinder
            {
                Count = model.SequenceBinder.Count,
                ItemTypeID = model.SequenceBinder.ItemTypeID
            }
        };
}
