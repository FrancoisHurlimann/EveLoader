using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Graphic
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string GraphicFile { get; set; }

        public string IconFolder { get; set; }

        public string SofFactionName { get; set; }

        public string SofHullName { get; set; }

        public string SofRaceName { get; set; }
    }
}
