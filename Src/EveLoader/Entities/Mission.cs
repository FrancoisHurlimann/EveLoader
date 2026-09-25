using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }
        public bool HasStandingRewards { get; set; }

        public MissionKillMission KillMission { get; set; }

        public List<MissionMessage> Messages { get; set; }

        public string Name { get; set; }
    }

    public class MissionKillMission
    {
        public long DungeonID { get; set; }

        public long ObjectiveQuantity { get; set; }
    }

    public class MissionMessage
    {
        public string Key { get; set; }

        public string De { get; set; }

        public string En { get; set; }

        public string Es { get; set; }

        public string Fr { get; set; }

        public string Ja { get; set; }

        public string Ko { get; set; }

        public string Ru { get; set; }

        public string Zh { get; set; }
    }
}
