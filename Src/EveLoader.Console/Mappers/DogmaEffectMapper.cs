using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DogmaEffectMapper
{
    public static DogmaEffect ToDbEntity(this Console.StaticDataModels.DogmaEffectFile model)
        => new DogmaEffect
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            DisallowAutoRepeat = model.DisallowAutoRepeat,
            DischargeAttributeID = model.DischargeAttributeID,
            DisplayName = model.DisplayName != null && model.DisplayName.TryGetValue("en", out var displayName)
                ? displayName
                : model.DisplayName?.Values.FirstOrDefault(),
            Distribution = model.Distribution,
            DurationAttributeID = model.DurationAttributeID,
            EffectCategoryID = model.EffectCategoryID,
            ElectronicChance = model.ElectronicChance,
            FalloffAttributeID = model.FalloffAttributeID,
            Guid = model.Guid,
            IconID = model.IconID,
            IsAssistance = model.IsAssistance,
            IsOffensive = model.IsOffensive,
            IsWarpSafe = model.IsWarpSafe,
            ModifierInfo = model.ModifierInfo?.Select(m => new DogmaEffectModifierInfo
            {
                Domain = m.Domain,
                Func = m.Func,
                ModifiedAttributeID = m.ModifiedAttributeID,
                ModifyingAttributeID = m.ModifyingAttributeID,
                Operation = m.Operation
            }).ToList(),
            Name = model.Name,
            PropulsionChance = model.PropulsionChance,
            Published = model.Published,
            RangeAttributeID = model.RangeAttributeID,
            RangeChance = model.RangeChance,
            TrackingSpeedAttributeID = model.TrackingSpeedAttributeID
        };
}
