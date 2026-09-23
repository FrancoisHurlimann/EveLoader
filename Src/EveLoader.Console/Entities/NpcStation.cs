using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class NpcStation
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public long CelestialIndex { get; set; }

        public long OperationID { get; set; }

        public long OrbitID { get; set; }

        public long? OrbitIndex { get; set; }

        public long OwnerID { get; set; }

        public NpcStationPosition Position { get; set; }

        public double ReprocessingEfficiency { get; set; }

        public long ReprocessingHangarFlag { get; set; }

        public double ReprocessingStationsTake { get; set; }

        public long SolarSystemID { get; set; }

        public long TypeID { get; set; }

        public bool UseOperationName { get; set; }
    }

    public class NpcStationPosition
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
    }
}
