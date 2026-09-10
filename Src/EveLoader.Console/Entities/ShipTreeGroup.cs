using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class ShipTreeGroup
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("elements")]
        public List<ShipTreeGroupElement> Elements { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("iconLarge")]
        public string IconLarge { get; set; }

        [JsonPropertyName("iconSmall")]
        public string IconSmall { get; set; }

        [JsonPropertyName("iconSmallNPC")]
        public string IconSmallNPC { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("preReqSkills")]
        public List<ShipTreeGroupPreReqSkillFaction> PreReqSkills { get; set; }
    }

    public class ShipTreeGroupElement
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }

    public class ShipTreeGroupPreReqSkillFaction
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("skills")]
        public List<ShipTreeGroupPreReqSkill> Skills { get; set; }
    }

    public class ShipTreeGroupPreReqSkill
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("display")]
        public bool Display { get; set; }

        [JsonPropertyName("level")]
        public long Level { get; set; }
    }
}
