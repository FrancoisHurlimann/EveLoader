using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace EveLoaderEntities
{
    public class SkinrSlotCategories
    {

        [Key]
        public int id { get; set; }

        [JsonPropertyName("_key")]
        public int key { get; set; }
        public required string name { get; set; }
    }
}
    