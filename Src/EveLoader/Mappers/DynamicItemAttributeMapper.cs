using System.Linq;
using EveLoaderEntities;

namespace EveLoader.Mappers;

public static class DynamicItemAttributeMapper
{
    public static DynamicItemAttribute ToDbEntity(this Console.StaticDataModels.DynamicItemAttributeFile model)
        => new DynamicItemAttribute
        {
            Key = model.Key,
            AttributeIDs = model.AttributeIDs?.Select(a => new DynamicItemAttributeRange
            {
                Key = a.Key,
                HighIsGood = a.HighIsGood,
                Max = a.Max,
                Min = a.Min
            }).ToList(),
            InputOutputMapping = model.InputOutputMapping?.Select(m => new DynamicItemInputOutputMapping
            {
                ApplicableTypes = m.ApplicableTypes?.ToList(),
                ResultingType = m.ResultingType
            }).ToList()
        };
}
