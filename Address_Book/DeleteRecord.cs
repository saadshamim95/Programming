using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Object_Oriented
{
    class DeleteRecord
    {
        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void delete(string file) {
            string json = File.ReadAllText(file);
            var jObject = JObject.Parse(json);
            JArray recordsArray = (JArray)jObject["Records"];
            Console.Write("Enter phone number to delete record: ");
            double number = Convert.ToDouble(Console.ReadLine());
            var recordToBeDeleted = recordsArray.FirstOrDefault(obj => obj["Number"].Value<double>() == number);
            bool delete = recordsArray.Remove(recordToBeDeleted);
            if (delete) {
                string jsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(file, jsonResult);
                Console.WriteLine("Record delted with phone number " + number);
            }
            else
                Console.WriteLine("No result found!!!");
        }
    }
}