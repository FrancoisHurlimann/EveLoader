using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class StationOperation
    {
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("activityID")]
        public long ActivityID { get; set; }

        [JsonPropertyName("border")]
        public double Border { get; set; }

        [JsonPropertyName("corridor")]
        public double Corridor { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("fringe")]
        public double Fringe { get; set; }

        [JsonPropertyName("hub")]
        public double Hub { get; set; }

        [JsonPropertyName("manufacturingFactor")]
        public double ManufacturingFactor { get; set; }

        [JsonPropertyName("operationName")]
        public string OperationName { get; set; }

        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        [JsonPropertyName("researchFactor")]
        public double ResearchFactor { get; set; }

        [JsonPropertyName("services")]
        public List<long> Services { get; set; }

        [JsonPropertyName("stationTypes")]
        public List<StationOperationStationType> StationTypes { get; set; }
    }

    public class StationOperationStationType
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }
}
