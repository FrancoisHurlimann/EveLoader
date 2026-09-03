using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class MilitaryCampaign
    {
        [JsonPropertyName("_key")]
        public string Key { get; set; }

        [JsonPropertyName("annotations")]
        public JsonElement Annotations { get; set; }

        [JsonPropertyName("issuer")]
        public MilitaryCampaignIssuer Issuer { get; set; }

        [JsonPropertyName("subtitle")]
        public Dictionary<string, string> Subtitle { get; set; }

        [JsonPropertyName("targetProgress")]
        public long TargetProgress { get; set; }

        [JsonPropertyName("title")]
        public Dictionary<string, string> Title { get; set; }
    }

    public class MilitaryCampaignIssuer
    {
        [JsonPropertyName("corporationID")]
        public long? CorporationID { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }
    }
}
