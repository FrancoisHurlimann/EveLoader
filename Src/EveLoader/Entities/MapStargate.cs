using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapStargate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long StargateDestinationSolarSystemID { get; set; }

        public long StargateDestinationStargateID { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public long SolarSystemID { get; set; }

        public long TypeID { get; set; }
    }

}
