using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Type
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public double? BasePrice { get; set; }

        public double? Capacity { get; set; }

        public string Description { get; set; }

        public long? GraphicID { get; set; }

        public long GroupID { get; set; }

        public long? IconID { get; set; }

        public double? Mass { get; set; }

        public string Name { get; set; }

        public long PortionSize { get; set; }

        public bool Published { get; set; }

        public long? RaceID { get; set; }

        public double? Radius { get; set; }

        public long? SoundID { get; set; }

        public double? Volume { get; set; }
    }
}
