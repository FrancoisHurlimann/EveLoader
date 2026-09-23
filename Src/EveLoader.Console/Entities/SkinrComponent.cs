using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class SkinrComponent
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public List<SkinrComponentAssociatedType> AssociatedTypeIds { get; set; }

        public long Category { get; set; }

        public string Finish { get; set; }

        public string IconFile { get; set; }

        public string Name { get; set; }

        public string ProjectionTypeU { get; set; }

        public string ProjectionTypeV { get; set; }

        public bool Published { get; set; }

        public long Rarity { get; set; }

        public string ResourceFile { get; set; }

        public SkinrComponentSequenceBinder SequenceBinder { get; set; }
    }

    public class SkinrComponentAssociatedType
    {
        public long LicenseUsesGranted { get; set; }

        public long TypeID { get; set; }
    }

    public class SkinrComponentSequenceBinder
    {
        public long Count { get; set; }

        public long ItemTypeID { get; set; }
    }
}
