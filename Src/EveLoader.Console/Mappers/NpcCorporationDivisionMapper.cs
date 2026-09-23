using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class NpcCorporationDivisionMapper
{
    public static NpcCorporationDivision ToDbEntity(this Console.StaticDataModels.NpcCorporationDivisionFile model)
        => new NpcCorporationDivision
        {
            Key = model.Key,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            DisplayName = model.DisplayName,
            InternalName = model.InternalName,
            LeaderTypeName = model.LeaderTypeName != null && model.LeaderTypeName.TryGetValue("en", out var leaderTypeName)
                ? leaderTypeName
                : model.LeaderTypeName?.Values.FirstOrDefault(),
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault()
        };
}
