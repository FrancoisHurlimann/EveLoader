using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class MissionMapper
{
    public static Mission ToDbEntity(this Console.StaticDataModels.MissionFile model)
        => new Mission
        {
            Key = model.Key,
            HasStandingRewards = model.HasStandingRewards,
            KillMission = model.KillMission == null
                ? null
                : new MissionKillMission
                {
                    DungeonID = model.KillMission.DungeonID,
                    ObjectiveQuantity = model.KillMission.ObjectiveQuantity
                },
            Messages = model.Messages?.Select(m => new MissionMessage
            {
                Key = m.Key,
                De = m.De,
                En = m.En,
                Es = m.Es,
                Fr = m.Fr,
                Ja = m.Ja,
                Ko = m.Ko,
                Ru = m.Ru,
                Zh = m.Zh
            }).ToList(),
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
