using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace EveLoaderEntities
{
    public class MilitaryCampaign
    {
        [Key]
        public int id { get; set; }

        public string Key { get; set; }

        public JsonElement Annotations { get; set; }

        public MilitaryCampaignIssuer Issuer { get; set; }

        public string Subtitle { get; set; }

        public long TargetProgress { get; set; }

        public string Title { get; set; }
    }

    public class MilitaryCampaignIssuer
    {
        public long? CorporationID { get; set; }

        public long? FactionID { get; set; }
    }
}
