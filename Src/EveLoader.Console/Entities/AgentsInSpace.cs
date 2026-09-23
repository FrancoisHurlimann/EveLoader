using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class AgentsInSpace
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long DungeonID { get; set; }

        public long SolarSystemID { get; set; }

        public long SpawnPointID { get; set; }

        public long TypeID { get; set; }
    }
}
