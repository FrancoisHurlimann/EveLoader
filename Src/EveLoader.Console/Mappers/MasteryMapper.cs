using System.Linq;
using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MasteryMapper
{
    public static Mastery ToDbEntity(this Console.StaticDataModels.MasteryFile model)
        => new Mastery
        {
            Key = model.Key,
            Value = model.Value?.Select(v => new MasteryLevel
            {
                Key = v.Key,
                Value = v.Value?.ToList()
            }).ToList()
        };
}
