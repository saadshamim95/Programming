using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Object_Oriented
{
    class BuyNewStock
    {
        /// <summary>
        /// Buys the stock.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void BuyStock(string fileName)
        {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            var jsonAccount = "";
            bool accountFound = false;
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

                    foreach (var item in accountArray.Where(obj => obj["Stock Symbol"].Value<string>() == company))
                    {
                        stockFound = true;
                    }

                    if (stockFound == true)
                    {
                        Console.WriteLine("Stock for " + company + " already exist in portfolio!!!");
                        
                    }

                    Console.Write("Enter the number of Stock you want to buy: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0 && (int)stock["Number of Shares"] > number)
                    {
                        stock["Number of Shares"] = (int)stock["Number of Shares"] - number;
                        jObject["Company"] = companyArray;
                        string result = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                        File.WriteAllText(pathCompany, result);

                        string record = "{ 'Stock Symbol': '" + stock["Stock Symbol"] + "','Number of Shares': " + number + ",'Share Price': " + stock["Share Price"] + "}";
                        var recordJson = JObject.Parse(record);
                        accountArray.Add(recordJson);
                        jsonObject[fileName] = accountArray;
                        string newJsonResult = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                        File.WriteAllText(path, newJsonResult);
                    }
                    else
                        Console.WriteLine("Not enough stock available!!!");

                    if (foundCompany == true)
                        break;

                }
            }
        }
    }
}