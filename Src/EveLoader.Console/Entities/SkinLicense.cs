using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinLicense
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long Duration { get; set; }

        public long LicenseTypeID { get; set; }

        public long SkinID { get; set; }
    }
}
