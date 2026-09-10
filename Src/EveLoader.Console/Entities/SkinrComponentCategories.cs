using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace EveLoader.Console.Entities
{
    public class SkinrComponentCategories
    {
   
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("_key")]
        public int Key { get; set; }

        public string Name { get; set; }
    }
}
    