using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveLoader.Console.StaticDataModels
{
    public class NpcCorporationFile
    {
        [JsonPropertyName("_key")]
        public long Key { get; set; }

        [JsonPropertyName("allowedMemberRaces")]
        public List<long> AllowedMemberRaces { get; set; }

        [JsonPropertyName("ceoID")]
        public long CeoID { get; set; }

        [JsonPropertyName("corporationTrades")]
        public List<NpcCorporationTrade> CorporationTrades { get; set; }

        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonPropertyName("divisions")]
        public List<NpcCorporationDivisionEntry> Divisions { get; set; }

        [JsonPropertyName("enemyID")]
        public long? EnemyID { get; set; }

        [JsonPropertyName("extent")]
        public string Extent { get; set; }

        [JsonPropertyName("factionID")]
        public long? FactionID { get; set; }

        [JsonPropertyName("friendID")]
        public long? FriendID { get; set; }

        [JsonPropertyName("hasPlayerPersonnelManager")]
        public bool HasPlayerPersonnelManager { get; set; }

        [JsonPropertyName("iconID")]
        public long? IconID { get; set; }

        [JsonPropertyName("initialPrice")]
        public long InitialPrice { get; set; }

        [JsonPropertyName("investors")]
        public List<NpcCorporationInvestor> Investors { get; set; }

        [JsonPropertyName("lpOfferTables")]
        public List<long> LpOfferTables { get; set; }

        [JsonPropertyName("mainActivityID")]
        public long? MainActivityID { get; set; }

        [JsonPropertyName("memberLimit")]
        public long MemberLimit { get; set; }

        [JsonPropertyName("minSecurity")]
        public double MinSecurity { get; set; }

        [JsonPropertyName("minimumJoinStanding")]
        public long MinimumJoinStanding { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonPropertyName("raceID")]
        public long? RaceID { get; set; }

        [JsonPropertyName("sendCharTerminationMessage")]
        public bool SendCharTerminationMessage { get; set; }

        [JsonPropertyName("shares")]
        public long Shares { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("sizeFactor")]
        public double? SizeFactor { get; set; }

        [JsonPropertyName("solarSystemID")]
        public long SolarSystemID { get; set; }

        [JsonPropertyName("stationID")]
        public long StationID { get; set; }

        [JsonPropertyName("taxRate")]
        public double TaxRate { get; set; }

        [JsonPropertyName("tickerName")]
        public string TickerName { get; set; }

        [JsonPropertyName("uniqueName")]
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
