//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.Json;
//using EveLoader.Entities;
//using System.IO;
//using System.Linq;
//using EveLoader.Console.StaticDataModels;

//namespace EveLoader.Services
//{
//    public class SerializationFiles
//    {
//        private readonly string _filePath;

//        public SerializationFiles(string filePath)
//        {
//            _filePath = filePath;
//        }

//        public List<SkinrComponentCategories> Load()
//        {

//            return File.ReadLines(_filePath)
//                .Select(line => JsonSerializer.Deserialize<SkinrComponentCategories>(line)!)
//               .ToList();

//            //return File.ReadLines(_filePath)
//            //    //.Where(line => !string.IsNullOrWhiteSpace(line))
//            //    .Select(line => JsonSerializer.Deserialize<SkinrComponentCategories>(line)!)
//            //    .ToDictionary(item => item._key);
//        }
//    }
//}
