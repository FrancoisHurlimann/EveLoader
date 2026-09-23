using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class ContrabandTypeMapper
{
    public static ContrabandType ToDbEntity(this Console.StaticDataModels.ContrabandTypeFile model)
        => new ContrabandType
        {
            Key = model.Key,
            Factions = model.Factions?.Select(f => new ContrabandFaction
            {
                Key = f.Key,
                AttackMinSec = f.AttackMinSec,
                ConfiscateMinSec = f.ConfiscateMinSec,
                FineByValue = f.FineByValue,
                StandingLoss = f.StandingLoss
            }).ToList()
        };
}
