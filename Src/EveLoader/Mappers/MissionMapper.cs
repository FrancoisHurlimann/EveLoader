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
            DungeonID = model.KillMission?.DungeonID ?? 0,
            ObjectiveQuantity = model.KillMission?.ObjectiveQuantity ?? 0,
            Message = model.Messages?.FirstOrDefault(m => m.Key == "en")?.En ?? string.Empty,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
