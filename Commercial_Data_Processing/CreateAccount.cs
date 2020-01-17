//-----------------------------------------------------------------------
// <copyright file="CreateAccount.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Object_Oriented
{
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