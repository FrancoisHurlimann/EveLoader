using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class NpcCorporation
    {
        public long Key { get; set; }

        public List<long> AllowedMemberRaces { get; set; }

        public long CeoID { get; set; }

        public List<NpcCorporationTrade> CorporationTrades { get; set; }

        public bool Deleted { get; set; }

        public Dictionary<string, string> Description { get; set; }

        public List<NpcCorporationDivisionEntry> Divisions { get; set; }

        public long? EnemyID { get; set; }

        public string Extent { get; set; }

        public long? FactionID { get; set; }

        public long? FriendID { get; set; }

        public bool HasPlayerPersonnelManager { get; set; }

        public long? IconID { get; set; }

        public long InitialPrice { get; set; }

        public List<NpcCorporationInvestor> Investors { get; set; }

        public List<long> LpOfferTables { get; set; }

        public long? MainActivityID { get; set; }

        public long MemberLimit { get; set; }

        public double MinSecurity { get; set; }

        public long MinimumJoinStanding { get; set; }

        public Dictionary<string, string> Name { get; set; }

        public long? RaceID { get; set; }

        public bool SendCharTerminationMessage { get; set; }

        public long Shares { get; set; }

        public string Size { get; set; }

        public double? SizeFactor { get; set; }

        public long SolarSystemID { get; set; }

        public long StationID { get; set; }

        public double TaxRate { get; set; }

        public string TickerName { get; set; }

        public bool UniqueName { get; set; }
    }

    public class NpcCorporationTrade
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public double Value { get; set; }
    }

    public class NpcCorporationDivisionEntry
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("divisionNumber")]
        public long DivisionNumber { get; set; }

        [JsonPropertyName("leaderID")]
        public long LeaderID { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }
    }

    public class NpcCorporationInvestor
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("_value")]
        public long Value { get; set; }
    }

}
