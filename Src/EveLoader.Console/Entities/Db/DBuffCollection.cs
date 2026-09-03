using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.Db
{
    public class DBuffCollection
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("aggregateMode")]
        public string AggregateMode { get; set; }

        [JsonPropertyName("developerDescription")]
        public string DeveloperDescription { get; set; }

        [JsonPropertyName("displayName")]
        public Dictionary<string, string> DisplayName { get; set; }

        [JsonPropertyName("itemModifiers")]
        public List<DBuffItemModifier> ItemModifiers { get; set; }

        [JsonPropertyName("locationGroupModifiers")]
        public List<DBuffLocationGroupModifier> LocationGroupModifiers { get; set; }

        [JsonPropertyName("locationModifiers")]
        public List<DBuffLocationModifier> LocationModifiers { get; set; }

        [JsonPropertyName("locationRequiredSkillModifiers")]
        public List<DBuffLocationRequiredSkillModifier> LocationRequiredSkillModifiers { get; set; }

        [JsonPropertyName("operationName")]
        public string OperationName { get; set; }

        [JsonPropertyName("showOutputValueInUI")]
        public string ShowOutputValueInUI { get; set; }
    }

    public class DBuffItemModifier
    {
        [JsonPropertyName("dogmaAttributeID")]
        public long DogmaAttributeID { get; set; }
    }

    public class DBuffLocationGroupModifier
    {
        [JsonPropertyName("dogmaAttributeID")]
        public long DogmaAttributeID { get; set; }

        [JsonPropertyName("groupID")]
        public long GroupID { get; set; }
    }

    public class DBuffLocationModifier
    {
        [JsonPropertyName("dogmaAttributeID")]
        public long DogmaAttributeID { get; set; }
    }

    public class DBuffLocationRequiredSkillModifier
    {
        [JsonPropertyName("dogmaAttributeID")]
        public long DogmaAttributeID { get; set; }

        [JsonPropertyName("skillID")]
        public long SkillID { get; set; }
    }
}
