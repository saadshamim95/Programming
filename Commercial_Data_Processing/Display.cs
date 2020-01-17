//-----------------------------------------------------------------------
// <copyright file="Display.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Object_Oriented  
{
    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Class for displaying File
    /// </summary>
    public class Display
    {
        /// <summary>
        /// Displays the shares.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void DisplayShares(string fileName)
        {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            var jsonAccount = string.Empty;
            bool accountFound = false;

            // Checking if account exist
            try
            {
                jsonAccount = File.ReadAllText(path);
                accountFound = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Account " + fileName + " doesn't exist!!!");
            }

            if (accountFound == true)
            {
                var json = File.ReadAllText(path);
                var jObject = JObject.Parse(json);
                JArray companyArray = (JArray)jObject[fileName];
                long total = 0;
                foreach (var stock in companyArray)
                {
                    Console.WriteLine();
                    Console.WriteLine("Stock Symbol: " + stock["Stock Symbol"]);
                    Console.WriteLine("Number of Shares: " + stock["Number of Shares"]);
                    Console.WriteLine("Share Price: " + stock["Share Price"]);
                    long sum = (int)stock["Number of Shares"] * (int)stock["Share Price"];
                    total = total + sum;
                    Console.WriteLine("Total Share Value of {0}: {1}", stock["Stock Symbol"], sum);
                }

                Console.WriteLine();
                if (fileName != "Company")
                {
                    Console.WriteLine("Total Share Value of {0}: {1}", fileName, total);
                }
            }
        }
    }
}