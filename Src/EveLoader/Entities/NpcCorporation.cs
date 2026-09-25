using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class NpcCharacter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public long BloodlineID { get; set; }

        public bool Ceo { get; set; }

        public long CorporationID { get; set; }

        public bool Gender { get; set; }

        public long LocationID { get; set; }

        public string Name { get; set; }

        public long RaceID { get; set; }

        public List<NpcCharacterSkill> Skills { get; set; }

        public DateTime StartDate { get; set; }

        public bool UniqueName { get; set; }
    }

    public class NpcCharacterSkill
    {
        public long TypeID { get; set; }
    }
}
