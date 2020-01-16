using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Object_Oriented
{
    class DisplayRecords
    {
        /// <summary>
        /// Displays the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void display(string file) {
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("                 Records                ");
            Console.WriteLine("****************************************");
            var json = File.ReadAllText(file);
            var jObject = JObject.Parse(json);
            JArray recordsArray = (JArray)jObject["Records"];
            if (recordsArray != null)
            {
                foreach (var item in recordsArray)
                {
                    Console.WriteLine("First Name: " + item["First"]);
                    Console.WriteLine("Last Name:  " + item["Last"]);
                    Console.WriteLine("Address:    " + item["Address"]);
                    Console.WriteLine("City:       " + item["City"]);
                    Console.WriteLine("State:      " + item["State"]);
                    Console.WriteLine("Zip:        " + item["Zip"]);
                    Console.WriteLine("Number:     " + item["Number"]);
                    Console.WriteLine();
                }
            }
        }
    }
}