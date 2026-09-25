using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveLoaderEntities
{
    public class DBuffCollection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Key { get; set; }

        public string AggregateMode { get; set; }

        public string DeveloperDescription { get; set; }

        public string? DisplayName { get; set; }

        public List<DBuffItemModifier> ItemModifiers { get; set; }

        public List<DBuffLocationGroupModifier> LocationGroupModifiers { get; set; }

        public List<DBuffLocationModifier> LocationModifiers { get; set; }

        public List<DBuffLocationRequiredSkillModifier> LocationRequiredSkillModifiers { get; set; }

        public string OperationName { get; set; }

        public string ShowOutputValueInUI { get; set; }
    }

    public class DBuffItemModifier
    {
        [Key]
        public long Key { get; set; }
        public long DogmaAttributeID { get; set; }
    }

    public class DBuffLocationGroupModifier
    {
        [Key]
        public long Key { get; set; }
        public long DogmaAttributeID { get; set; }

        public long GroupID { get; set; }
    }

    public class DBuffLocationModifier
    {
        [Key]
        public long Key { get; set; }
        public long DogmaAttributeID { get; set; }
    }

    public class DBuffLocationRequiredSkillModifier
    {
        [Key]
        public long Key { get; set; }
        public long DogmaAttributeID { get; set; }

        public long SkillID { get; set; }
    }
}
