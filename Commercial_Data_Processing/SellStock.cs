//-----------------------------------------------------------------------
// <copyright file="SellStock.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Object_Oriented
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Class for selling stocks
    /// </summary>
    public class SellStock
    {
        /// <summary>
        /// Sells the shares.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void SellShares(string fileName)
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
                var jsonObject = JObject.Parse(jsonAccount);
                JArray accountArray = (JArray)jsonObject[fileName];
                Console.Write("Which company stock you want to sell: ");
                string company = Console.ReadLine();
                bool foundCompany = false;
                
                foreach (var stock in accountArray.Where(obj => obj["Stock Symbol"].Value<string>() == company))
                {
                    foundCompany = true;
                    Console.Write("Enter the number of Stock you want to sell: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0 && (int)stock["Number of Shares"] > number)
                    {
                        stock["Number of Shares"] = (int)stock["Number of Shares"] - number;
                        jsonObject[fileName] = accountArray;
                        string result = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                        File.WriteAllText(path, result);
                        Console.WriteLine("Shares of " + company + " sold and account " + fileName + " updated!!!");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough " + company + " shares!!!");
                    }
                }

                if (foundCompany == false)
                {
                    Console.WriteLine("You don't have shares of " + company);
                }
            }
        }
    }
}