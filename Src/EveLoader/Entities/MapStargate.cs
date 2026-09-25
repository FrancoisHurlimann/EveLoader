using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapStargate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public StargateDestination Destination { get; set; }

        public Position Position { get; set; }

        public long SolarSystemID { get; set; }

        public long TypeID { get; set; }
    }

    public class StargateDestination
    {
        public long SolarSystemID { get; set; }

        public long StargateID { get; set; }
    }
}
