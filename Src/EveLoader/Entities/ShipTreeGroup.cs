using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class ShipTreeGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string Description { get; set; }

        public List<ShipTreeGroupElement> Elements { get; set; }

        public string Icon { get; set; }

        public string IconLarge { get; set; }

        public string IconSmall { get; set; }

        public string IconSmallNPC { get; set; }

        public string Name { get; set; }

        public List<ShipTreeGroupPreReqSkillFaction> PreReqSkills { get; set; }
    }

    public class ShipTreeGroupElement
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }

    public class ShipTreeGroupPreReqSkillFaction
    {
        public long Key { get; set; }

        public List<ShipTreeGroupPreReqSkill> Skills { get; set; }
    }

    public class ShipTreeGroupPreReqSkill
    {
        public long Key { get; set; }

        public bool Display { get; set; }

        public long Level { get; set; }
    }
}
