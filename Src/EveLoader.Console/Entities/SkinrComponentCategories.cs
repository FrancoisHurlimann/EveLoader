using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace EveLoader.Entities
{
    public class SkinrComponentCategories
    {
   
        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public int key { get; set; }

        public required string name { get; set; }
    }
}
    