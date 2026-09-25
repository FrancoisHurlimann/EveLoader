using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class TypeBonus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public List<TypeBonusRoleBonus> RoleBonuses { get; set; }

        public List<TypeBonusTypeEntry> Types { get; set; }
    }

    public class TypeBonusRoleBonus
    {
        [Key]
        public long Key { get; set; }

        public double Bonus { get; set; }

        public string BonusText { get; set; }

        public long Importance { get; set; }

        public long UnitID { get; set; }

        public int TypeBonusId { get; set; }
    }

    public class TypeBonusTypeEntry
    {
    
        public long Key { get; set; }

        public List<TypeBonusTypeBonus> Value { get; set; }

        public int TypeBonusId { get; set; }
    }

    public class TypeBonusTypeBonus
    {
        [Key]
        public long Key { get; set; }

        public double Bonus { get; set; }

        public string BonusText { get; set; }

        public long Importance { get; set; }

        public long UnitID { get; set; }

        public int TypeBonusTypeEntryId { get; set; }
    }
}
