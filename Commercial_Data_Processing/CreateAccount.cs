//-----------------------------------------------------------------------
// <copyright file="CreateAccount.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Object_Oriented
{
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    
    /// <summary>
    /// Class for Creating Account
    /// </summary>
    public class CreateAccount
    {
        /// <summary>
        /// Creates the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public static void Create(string fileName)
        {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            if (File.Exists(path))
            {
                Console.WriteLine("Account with " + fileName + " already exist!!!");
            }
            else
            {
                string print = "{\n" +
                "'" + fileName + "':[\n" +
                "]\n" +
                "}";
                var record = JObject.Parse(print);
                string jsonResult = JsonConvert.SerializeObject(record, Formatting.Indented);
                File.WriteAllText(path, jsonResult);
                Console.WriteLine("Account Successfully Created!!!");
            }
        }
    }
}