using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EveLoaderEntities
{
    public class SkinrComponentCategories
    {
   
        [Key]
        public int Id { get; set; }

        public int Key { get; set; }

        public string Name { get; set; }
    }
}
    
