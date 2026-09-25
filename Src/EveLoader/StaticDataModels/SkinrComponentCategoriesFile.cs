using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EveLoader.Console.StaticDataModels
{
    public class SkinrComponentCategoriesFile
    {
   
        public int _key { get; set; }
        public required string name { get; set; }
    }
}
    