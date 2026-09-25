using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapConstellation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long? FactionID { get; set; }

        public string Name { get; set; }

        public Position Position { get; set; }

        public long RegionID { get; set; }

        public List<long> SolarSystemIDs { get; set; }

        public long? WormholeClassID { get; set; }
    }
}
