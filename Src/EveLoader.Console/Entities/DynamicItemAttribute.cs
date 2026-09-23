using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class DynamicItemAttribute
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<DynamicItemAttributeRange> AttributeIDs { get; set; }

        public List<DynamicItemInputOutputMapping> InputOutputMapping { get; set; }
    }

    public class DynamicItemAttributeRange
    {
        public long Key { get; set; }

        public bool? HighIsGood { get; set; }

        public double Max { get; set; }

        public double Min { get; set; }
    }

    public class DynamicItemInputOutputMapping
    {
        public List<long> ApplicableTypes { get; set; }

        public long ResultingType { get; set; }
    }
}
