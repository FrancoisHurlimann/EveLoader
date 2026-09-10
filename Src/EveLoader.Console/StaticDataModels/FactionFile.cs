using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class FactionFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("corporationID")]
        public long CorporationID { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("flatLogo")]
        public string FlatLogo { get; set; }

        [JsonPropertyName("flatLogoWithName")]
        public string FlatLogoWithName { get; set; }

        [JsonPropertyName("iconID")]
        public long IconID { get; set; }

        [JsonPropertyName("memberRaces")]
        public List<long> MemberRaces { get; set; }

        [JsonPropertyName("militiaCorporationID")]
        public long? MilitiaCorporationID { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("shortDescription")]
        public Dictionary<string, string> ShortDescription { get; set; }

        [JsonPropertyName("sizeFactor")]
        public double SizeFactor { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("uniqueName")]
        public bool UniqueName { get; set; }
    }
}
