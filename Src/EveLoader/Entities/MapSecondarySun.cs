using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class MapSecondarySun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long EffectBeaconTypeID { get; set; }

        public Position Position { get; set; }

        public long SolarSystemID { get; set; }

        public long TypeID { get; set; }
    }
}
