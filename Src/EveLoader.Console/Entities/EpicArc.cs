using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class EpicArc
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long ArcRestartInterval { get; set; }

        public long? FactionID { get; set; }

        public long IconID { get; set; }

        public List<EpicArcMission> Missions { get; set; }

        public string Name { get; set; }
    }

    public class EpicArcMission
    {
        public long Key { get; set; }

        public long AgentID { get; set; }

        public long? FailMissionID { get; set; }

        public List<long> NextMissions { get; set; }
    }
}
