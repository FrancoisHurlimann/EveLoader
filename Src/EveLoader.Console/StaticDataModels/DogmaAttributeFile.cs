using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class DogmaAttributeFile
    {
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
        public Dictionary<string, string> DisplayName { get; set; }

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
        public Dictionary<string, string> TooltipDescription { get; set; }

        [JsonPropertyName("tooltipTitle")]
        public Dictionary<string, string> TooltipTitle { get; set; }

        [JsonPropertyName("unitID")]
        public long? UnitID { get; set; }
    }
}
