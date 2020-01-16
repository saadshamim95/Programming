using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Object_Oriented
{
    class AddRecord
    {
        /// <summary>
        /// Adds the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void add(string file) {
            Console.Write("First Name: ");
            string First = Console.ReadLine();
            Console.Write("Last Name: ");
            string Last = Console.ReadLine();
            Console.Write("Address: ");
            string Address = Console.ReadLine();
            Console.Write("City: ");
            string City = Console.ReadLine();
            Console.Write("State: ");
            string State = Console.ReadLine();
            Console.Write("Zip: ");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number: ");
            double Number = Convert.ToDouble(Console.ReadLine());

            var newRecord = "{ 'First': '" + First + "','Last': '" + Last + "','Address': '" + Address + "','City': '" + City + "','State': '" + State + "','Zip': " + Zip + ",'Number': " + Number + "}";
            var json = File.ReadAllText(file);
            var jsonObject = JObject.Parse(json);
            var recordsArray = jsonObject.GetValue("Records") as JArray;
            var record = JObject.Parse(newRecord);
            recordsArray.Add(record);
            jsonObject["Records"] = recordsArray;
            string newJsonResult = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText(file, newJsonResult);
        }
    }
}