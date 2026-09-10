using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class DogmaAttribute
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("attributeCategoryID")]
        public long AttributeCategoryID { get; set; }

        [JsonPropertyName("dataType")]
        public long DataType { get; set; }

        [JsonPropertyName("defaultValue")]
        public double DefaultValue { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("displayWhenZero")]
        public bool DisplayWhenZero { get; set; }

        [JsonPropertyName("highIsGood")]
        public bool HighIsGood { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonPropertyName("stackable")]
        public bool Stackable { get; set; }

        [JsonPropertyName("tooltipDescription")]
        public string TooltipDescription { get; set; }

        [JsonPropertyName("tooltipTitle")]
        public string TooltipTitle { get; set; }

        [JsonPropertyName("unitID")]
        public long? UnitID { get; set; }
    }
}
