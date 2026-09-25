using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class DBuffCollectionMapper
{
    public static DBuffCollection ToDbEntity(this Console.StaticDataModels.DBuffCollectionFile model)
        => new DBuffCollection
        {
            Key = model.Key,
            AggregateMode = model.AggregateMode,
            DeveloperDescription = model.DeveloperDescription,
            DisplayName = model.DisplayName != null && model.DisplayName.TryGetValue("en", out var displayName)
                ? displayName
                : model.DisplayName?.Values.FirstOrDefault(),
            ItemModifiers = model.ItemModifiers?.Select(m => new DBuffItemModifier
            {
                DogmaAttributeID = m.DogmaAttributeID
            }).ToList(),
            LocationGroupModifiers = model.LocationGroupModifiers?.Select(m => new DBuffLocationGroupModifier
            {
                DogmaAttributeID = m.DogmaAttributeID,
                GroupID = m.GroupID
            }).ToList(),
            LocationModifiers = model.LocationModifiers?.Select(m => new DBuffLocationModifier
            {
                DogmaAttributeID = m.DogmaAttributeID
            }).ToList(),
            LocationRequiredSkillModifiers = model.LocationRequiredSkillModifiers?.Select(m => new DBuffLocationRequiredSkillModifier
            {
                DogmaAttributeID = m.DogmaAttributeID,
                SkillID = m.SkillID
            }).ToList(),
            OperationName = model.OperationName,
            ShowOutputValueInUI = model.ShowOutputValueInUI
        };
}
