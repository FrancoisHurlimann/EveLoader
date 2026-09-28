using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapRegion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<long>? ConstellationIDs { get; set; }

        public string? Description { get; set; }

        public long? FactionID { get; set; }

        public string? Name { get; set; }

        public long NebulaID { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public long? WormholeClassID { get; set; }
    }
}
