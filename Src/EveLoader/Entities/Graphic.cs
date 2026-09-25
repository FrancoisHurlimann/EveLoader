using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Graphic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string GraphicFile { get; set; }

        public string IconFolder { get; set; }

        public string SofFactionName { get; set; }

        public string SofHullName { get; set; }

        public string SofRaceName { get; set; }
    }
}
