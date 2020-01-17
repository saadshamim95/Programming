using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_Oriented
{
    class ReadFromFile
    {
        /// <summary>
        /// Reads this instance.
        /// </summary>
        public static void Read(string fileName) {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            string json = File.ReadAllText(path);
            JObject jObject = JObject.Parse(json);
            JArray array = (JArray)jObject["Saad"];
            foreach (var item in array) {
                Console.WriteLine("First: " + item["First"]);
                Console.WriteLine("Last: " + item["Last"]);
            }
                
            //Console.WriteLine(json);
        }
    }
}
