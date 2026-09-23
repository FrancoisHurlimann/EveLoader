using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class MapSecondarySun
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long EffectBeaconTypeID { get; set; }

        public Position Position { get; set; }

        public long SolarSystemID { get; set; }

        public long TypeID { get; set; }
    }
}
