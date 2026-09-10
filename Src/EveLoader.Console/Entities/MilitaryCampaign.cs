using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class MilitaryCampaign
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("annotations")]
        public JsonElement Annotations { get; set; }

        [JsonPropertyName("issuer")]
        public MilitaryCampaignIssuer Issuer { get; set; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; set; }

        [JsonPropertyName("targetProgress")]
        public long TargetProgress { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class MilitaryCampaignIssuer
    {
        [JsonPropertyName("corporationID")]
        public long? CorporationID { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }
    }
}
