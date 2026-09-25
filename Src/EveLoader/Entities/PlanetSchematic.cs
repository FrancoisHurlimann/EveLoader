using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class PlanetSchematic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long CycleTime { get; set; }

        public string Name { get; set; }

        public List<long> Pins { get; set; }

        public List<PlanetSchematicType> Types { get; set; }
    }

    public class PlanetSchematicType
    {
        public long Key { get; set; }

        public bool IsInput { get; set; }

        public long Quantity { get; set; }
    }
}
