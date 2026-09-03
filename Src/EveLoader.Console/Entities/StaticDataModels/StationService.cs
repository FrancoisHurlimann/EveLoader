using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Entities.StaticDataModels
{
    public class StationService
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("serviceName")]
        public Dictionary<string, string> ServiceName { get; set; }
    }
}
