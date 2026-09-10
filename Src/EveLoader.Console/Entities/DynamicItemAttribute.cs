using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class DynamicItemAttribute
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("attributeIDs")]
        public List<DynamicItemAttributeRange> AttributeIDs { get; set; }

        [JsonPropertyName("inputOutputMapping")]
        public List<DynamicItemInputOutputMapping> InputOutputMapping { get; set; }
    }

    public class DynamicItemAttributeRange
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("highIsGood")]
        public bool? HighIsGood { get; set; }

        [JsonPropertyName("max")]
        public double Max { get; set; }

        [JsonPropertyName("min")]
        public double Min { get; set; }
    }

    public class DynamicItemInputOutputMapping
    {
        [JsonPropertyName("applicableTypes")]
        public List<long> ApplicableTypes { get; set; }

        [JsonPropertyName("resultingType")]
        public long ResultingType { get; set; }
    }
}
