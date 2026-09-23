using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class EpicArcMapper
{
    public static EpicArc ToDbEntity(this Console.StaticDataModels.EpicArcFile model)
        => new EpicArc
        {
            Key = model.Key,
            ArcRestartInterval = model.ArcRestartInterval,
            FactionID = model.FactionID,
            IconID = model.IconID,
            Missions = model.Missions?.Select(m => new EpicArcMission
            {
                Key = m.Key,
                AgentID = m.AgentID,
                FailMissionID = m.FailMissionID,
                NextMissions = m.NextMissions?.ToList()
            }).ToList(),
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
