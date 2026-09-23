using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class TypeBonusMapper
{
    public static TypeBonus ToDbEntity(this Console.StaticDataModels.TypeBonusFile model)
        => new TypeBonus
        {
            Key = model.Key,
            RoleBonuses = model.RoleBonuses?.Select(r => new TypeBonusRoleBonus
            {
                Bonus = r.Bonus,
                BonusText = r.BonusText != null && r.BonusText.TryGetValue("en", out var bonusText)
                    ? bonusText
                    : r.BonusText?.Values.FirstOrDefault(),
                Importance = r.Importance,
                UnitID = r.UnitID
            }).ToList(),
            Types = model.Types?.Select(t => new TypeBonusTypeEntry
            {
                Key = t.Key,
                Value = t.Value?.Select(v => new TypeBonusTypeBonus
                {
                    Bonus = v.Bonus,
                    BonusText = v.BonusText != null && v.BonusText.TryGetValue("en", out var bonusText)
                        ? bonusText
                        : v.BonusText?.Values.FirstOrDefault(),
                    Importance = v.Importance,
                    UnitID = v.UnitID
                }).ToList()
            }).ToList()
        };
}
