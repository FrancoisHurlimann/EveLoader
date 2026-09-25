using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class DogmaEffectFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("disallowAutoRepeat")]
        public bool DisallowAutoRepeat { get; set; }

        [JsonPropertyName("dischargeAttributeID")]
        public long? DischargeAttributeID { get; set; }

        [JsonPropertyName("displayName")]
        public Dictionary<string, string> DisplayName { get; set; }

        [JsonPropertyName("distribution")]
        public long? Distribution { get; set; }

        [JsonPropertyName("durationAttributeID")]
        public long? DurationAttributeID { get; set; }

        [JsonPropertyName("effectCategoryID")]
        public long EffectCategoryID { get; set; }

        [JsonPropertyName("electronicChance")]
        public bool ElectronicChance { get; set; }

        [JsonPropertyName("falloffAttributeID")]
        public long? FalloffAttributeID { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("isAssistance")]
        public bool IsAssistance { get; set; }

        [JsonPropertyName("isOffensive")]
        public bool IsOffensive { get; set; }

        [JsonPropertyName("isWarpSafe")]
        public bool IsWarpSafe { get; set; }

        [JsonPropertyName("modifierInfo")]
        public List<DogmaEffectModifierInfo> ModifierInfo { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("propulsionChance")]
        public bool PropulsionChance { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonPropertyName("rangeAttributeID")]
        public long? RangeAttributeID { get; set; }

        [JsonPropertyName("rangeChance")]
        public bool RangeChance { get; set; }

        [JsonPropertyName("trackingSpeedAttributeID")]
        public long? TrackingSpeedAttributeID { get; set; }
    }

    public class DogmaEffectModifierInfo
    {
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("func")]
        public string Func { get; set; }

        [JsonPropertyName("modifiedAttributeID")]
        public long ModifiedAttributeID { get; set; }

        [JsonPropertyName("modifyingAttributeID")]
        public long ModifyingAttributeID { get; set; }

        [JsonPropertyName("operation")]
        public long Operation { get; set; }
    }
}
