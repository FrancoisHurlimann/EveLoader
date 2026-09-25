using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class FactionMapper
{
    public static Faction ToDbEntity(this Console.StaticDataModels.FactionFile model)
        => new Faction
        {
            Key = model.Key,
            CorporationID = model.CorporationID,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            FlatLogo = model.FlatLogo,
            FlatLogoWithName = model.FlatLogoWithName,
            IconID = model.IconID,
            MemberRaces = model.MemberRaces?.ToList(),
            MilitiaCorporationID = model.MilitiaCorporationID,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            ShortDescription = model.ShortDescription != null && model.ShortDescription.TryGetValue("en", out var shortDescription)
                ? shortDescription
                : model.ShortDescription?.Values.FirstOrDefault(),
            SizeFactor = model.SizeFactor,
            SolarSystemID = model.SolarSystemID,
            UniqueName = model.UniqueName
        };
}
