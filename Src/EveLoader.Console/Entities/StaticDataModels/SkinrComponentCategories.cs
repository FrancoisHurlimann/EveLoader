using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EveLoader.Entities.StaticDataModels
{
    public class SkinrComponentCategories
    {
   
        public int _key { get; set; }
        public required string name { get; set; }
    }
}
    