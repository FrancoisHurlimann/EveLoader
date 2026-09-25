using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Faction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long CorporationID { get; set; }

        public string Description { get; set; }

        public string FlatLogo { get; set; }

        public string FlatLogoWithName { get; set; }

        public long IconID { get; set; }

        public List<long> MemberRaces { get; set; }

        public long? MilitiaCorporationID { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public double SizeFactor { get; set; }

        public long SolarSystemID { get; set; }

        public bool UniqueName { get; set; }
    }
}
