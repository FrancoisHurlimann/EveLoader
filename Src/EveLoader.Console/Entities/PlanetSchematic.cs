using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class PlanetSchematic
    {
        [Key]
        public int id { get; set; }

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
