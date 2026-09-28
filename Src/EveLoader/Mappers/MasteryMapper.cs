using EveLoader.Console.StaticDataModels;
using EveLoaderEntities;
using System.Linq;

namespace EveLoader.Mappers;

public static class MasteryMapper
{
    public static Mastery ToDbEntity(this Console.StaticDataModels.MasteryFile model)
        => new Mastery
        {
            Key = model.Key,
            Value = model.Value?.SelectMany(level => level.Value).ToList()
        };
}
