using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class NpcCharacter
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("bloodlineID")]
        public long BloodlineID { get; set; }

        [JsonPropertyName("ceo")]
        public bool Ceo { get; set; }

        [JsonPropertyName("corporationID")]
        public long CorporationID { get; set; }

        [JsonPropertyName("gender")]
        public bool Gender { get; set; }

        [JsonPropertyName("locationID")]
        public long LocationID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("raceID")]
        public long RaceID { get; set; }

        [JsonPropertyName("skills")]
        public List<NpcCharacterSkill> Skills { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("uniqueName")]
        public bool UniqueName { get; set; }
    }

    public class NpcCharacterSkill
    {
        [JsonPropertyName("typeID")]
        public long TypeID { get; set; }
    }
}
