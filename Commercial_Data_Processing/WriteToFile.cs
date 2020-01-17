using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_Oriented
{
    class WriteToFile
    {
        /// <summary>
        /// Writes this instance.
        /// </summary>
        public static void Write(string fileName) {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            string print = "{\n" +
                "'" + fileName + "':[\n" +
                "]\n" +
                "}";
            var record = JObject.Parse(print);
            string jsonResult = JsonConvert.SerializeObject(record, Formatting.Indented);
            File.WriteAllText(path, jsonResult);
        }
    }
}