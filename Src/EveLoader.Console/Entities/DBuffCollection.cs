using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EveLoaderEntities
{
    public class DBuffCollection
    {
        [Key]
        public int id { get; set; }

        public long Key { get; set; }

        public string AggregateMode { get; set; }

        public string DeveloperDescription { get; set; }

        public string DisplayName { get; set; }

        public List<DBuffItemModifier> ItemModifiers { get; set; }

        public List<DBuffLocationGroupModifier> LocationGroupModifiers { get; set; }

        public List<DBuffLocationModifier> LocationModifiers { get; set; }

        public List<DBuffLocationRequiredSkillModifier> LocationRequiredSkillModifiers { get; set; }

        public string OperationName { get; set; }

        public string ShowOutputValueInUI { get; set; }
    }

    public class DBuffItemModifier
    {
        public long DogmaAttributeID { get; set; }
    }

    public class DBuffLocationGroupModifier
    {
        public long DogmaAttributeID { get; set; }

        public long GroupID { get; set; }
    }

    public class DBuffLocationModifier
    {
        public long DogmaAttributeID { get; set; }
    }

    public class DBuffLocationRequiredSkillModifier
    {
        public long DogmaAttributeID { get; set; }

        public long SkillID { get; set; }
    }
}
