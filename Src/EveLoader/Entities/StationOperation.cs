using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class StationOperation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long ActivityID { get; set; }

        public double Border { get; set; }

        public double Corridor { get; set; }

        public string Description { get; set; }

        public double Fringe { get; set; }

        public double Hub { get; set; }

        public double ManufacturingFactor { get; set; }

        public string OperationName { get; set; }

        public double Ratio { get; set; }

        public double ResearchFactor { get; set; }

        public List<long> Services { get; set; }

        public List<StationOperationStationType> StationTypes { get; set; }
    }

    public class StationOperationStationType
    {
        public long Key { get; set; }

        public long Value { get; set; }
    }
}
