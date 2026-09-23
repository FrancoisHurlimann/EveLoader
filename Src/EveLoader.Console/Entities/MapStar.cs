using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class MapStar
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long Radius { get; set; }

        public long SolarSystemID { get; set; }

        public StarStatistics Statistics { get; set; }

        public long TypeID { get; set; }
    }

    public class StarStatistics
    {
        public double Age { get; set; }

        public double Life { get; set; }

        public double Luminosity { get; set; }

        public string SpectralClass { get; set; }

        public double Temperature { get; set; }
    }
}
