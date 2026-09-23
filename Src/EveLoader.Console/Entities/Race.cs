using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class Race
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public long IconID { get; set; }

        public string Name { get; set; }

        public long? ShipTypeID { get; set; }

        public List<RaceSkill> Skills { get; set; }
    }

    public class RaceSkill
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
