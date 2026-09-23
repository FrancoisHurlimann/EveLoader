using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EveLoaderEntities
{
    public class SkinrSlotCategories
    {

        [Key]
        public int id { get; set; }

        public int key { get; set; }
        public required string name { get; set; }
    }
}
    
