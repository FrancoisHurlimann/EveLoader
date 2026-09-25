using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class DynamicItemAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
