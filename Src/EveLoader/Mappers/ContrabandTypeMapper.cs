using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class ContrabandTypeMapper
{
    public static ContrabandType ToDbEntity(this Console.StaticDataModels.ContrabandTypeFile model)
        => new ContrabandType
        {
            Key = model.Key,
            Factions = model.Factions?.Select(f => new ContrabandFaction
            {
                AttackMinSec = f.AttackMinSec,
                ConfiscateMinSec = f.ConfiscateMinSec,
                FineByValue = f.FineByValue,
                StandingLoss = f.StandingLoss
            }).ToList()
        };
}
