using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EveLoader.Entities
{
    public class SkinrComponentCategories
    {
   
        [Key]
        public int id { get; set; }
        public int key { get; set; }
        public required string name { get; set; }
    }
}
    