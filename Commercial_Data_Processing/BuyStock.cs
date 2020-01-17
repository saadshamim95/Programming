//-----------------------------------------------------------------------
// <copyright file="BuyStock.cs" company="BridgeLabz">
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
    /// Class for buying Stock
    /// </summary>
    public class BuyStock
    {
        /// <summary>
        /// Buys the shares.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void BuyShares(string fileName)
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
                // Parsing fileName.json
                var jsonObject = JObject.Parse(jsonAccount);
                JArray accountArray = (JArray)jsonObject[fileName];

                // Parsing Company.json
                string pathCompany = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\Company.json";
                var jsonCompany = File.ReadAllText(pathCompany);
                var jObject = JObject.Parse(jsonCompany);
                JArray companyArray = (JArray)jObject["Company"];
 
                Console.Write("Which company stock you want to buy: ");
                string company = Console.ReadLine();
                bool foundCompany = false;
                bool stockFound = false;

                foreach (var stock in companyArray.Where(obj => obj["Stock Symbol"].Value<string>() == company))
                {
                    foundCompany = true;
                    Console.Write("Enter the number of Stock you want to buy: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number > 0 && (int)stock["Number of Shares"] > number)
                    {
                        // Updating in Company.json
                        stock["Number of Shares"] = (int)stock["Number of Shares"] - number;
                        jObject["Company"] = companyArray;
                        string result = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                        File.WriteAllText(pathCompany, result);

                        // updating fileName.json for existing stock
                        foreach (var item in accountArray.Where(obj => obj["Stock Symbol"].Value<string>() == company))
                        {
                            stockFound = true;
                            item["Number of Shares"] = (int)item["Number of Shares"] + number;
                            jsonObject[fileName] = accountArray;
                            string account = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                            File.WriteAllText(path, account);
                            Console.WriteLine("Existing entry updated!!!");
                        }

                        // Creating new stock and updating fileName.json
                        if (stockFound == false)
                        {
                            string record = "{ 'Stock Symbol': '" + stock["Stock Symbol"] + "','Number of Shares': " + number + ",'Share Price': " + stock["Share Price"] + "}";
                            var recordJson = JObject.Parse(record);
                            accountArray.Add(recordJson);
                            jsonObject[fileName] = accountArray;
                            string newJsonResult = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                            File.WriteAllText(path, newJsonResult);
                            Console.WriteLine("New entry added!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough stock available!!!");
                    }

                    if (foundCompany == true)
                    {
                        break;
                    }
                }
            }
        }
    }
}