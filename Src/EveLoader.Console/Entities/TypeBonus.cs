using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class TypeBonus
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("roleBonuses")]
        public List<TypeBonusRoleBonus> RoleBonuses { get; set; }

        [JsonPropertyName("types")]
        public List<TypeBonusTypeEntry> Types { get; set; }
    }

    public class TypeBonusRoleBonus
    {
        [JsonPropertyName("bonus")]
        public double Bonus { get; set; }

        [JsonPropertyName("bonusText")]
        public string BonusText { get; set; }

        [JsonPropertyName("importance")]
        public long Importance { get; set; }

        [JsonPropertyName("unitID")]
        public long UnitID { get; set; }
    }

    public class TypeBonusTypeEntry
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public List<TypeBonusTypeBonus> Value { get; set; }
    }

    public class TypeBonusTypeBonus
    {
        [JsonPropertyName("bonus")]
        public double Bonus { get; set; }

        [JsonPropertyName("bonusText")]
        public string BonusText { get; set; }

        [JsonPropertyName("importance")]
        public long Importance { get; set; }

        [JsonPropertyName("unitID")]
        public long UnitID { get; set; }
    }
}
