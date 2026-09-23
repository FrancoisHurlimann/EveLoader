using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class DogmaEffect
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string Description { get; set; }

        public bool DisallowAutoRepeat { get; set; }

        public long? DischargeAttributeID { get; set; }

        public string DisplayName { get; set; }

        public long? Distribution { get; set; }

        public long? DurationAttributeID { get; set; }

        public long EffectCategoryID { get; set; }

        public bool ElectronicChance { get; set; }

        public long? FalloffAttributeID { get; set; }

        public string Guid { get; set; }

        public long? IconID { get; set; }

        public bool IsAssistance { get; set; }

        public bool IsOffensive { get; set; }

        public bool IsWarpSafe { get; set; }

        public List<DogmaEffectModifierInfo> ModifierInfo { get; set; }

        public string Name { get; set; }

        public bool PropulsionChance { get; set; }

        public bool Published { get; set; }

        public long? RangeAttributeID { get; set; }

        public bool RangeChance { get; set; }

        public long? TrackingSpeedAttributeID { get; set; }
    }

    public class DogmaEffectModifierInfo
    {
        public string Domain { get; set; }

        public string Func { get; set; }

        public long ModifiedAttributeID { get; set; }

        public long ModifyingAttributeID { get; set; }

        public long Operation { get; set; }
    }
}
