using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Object_Oriented
{
    class UpdateRecord
    {
        /// <summary>
        /// Updates the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void update(string file) {
            string json = File.ReadAllText(file);
            var jObject = JObject.Parse(json);
            JArray recordsArray = (JArray)jObject["Records"];
            Console.Write("Enter Phone Number to update Address: ");
            var number = Convert.ToDouble(Console.ReadLine());
            bool found = false;
            foreach (var num in recordsArray.Where(obj => obj["Number"].Value<double>() == number)) {
                found = true;
                Console.Write("Enter new Address: ");
                string address = Console.ReadLine();
                num["Address"] = address;
                jObject["Records"] = recordsArray;
                string jsonResult = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(file, jsonResult);
            }
            if (found == false)
                Console.WriteLine("No record available with this number!!!");
        }
    }
}