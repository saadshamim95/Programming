using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Object_Oriented
{
    /// <summary>
    /// Class for buying Stock
    /// </summary>
    public class BuyExistingStock
    {
        /// <summary>
        /// Buys the stock.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void BuyStock(string fileName)
        {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            string readAccount = File.ReadAllText(path);
            string readCompany = File.ReadAllText(@"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\Company.json");
            string company = "Reliance";
            var jObject = JObject.Parse(readCompany);
            JArray companyArray = (JArray)jObject["Company"];
            foreach (var stock in companyArray.Where(obj => obj["Stock Symbol"].Value<string>() == company)) {
                Console.WriteLine("How many stocks you want to buy: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && (int)stock["Number of Shares"] > number)
                {                                                                                                  
                    stock["Number of Shares"] = (int)stock["Number of Shares"] - number;
                    var jObjectAccount = JObject.Parse(readAccount);
                    JArray accountArray = (JArray)jObjectAccount[fileName];
                    Console.WriteLine("Here");
                }
                else
                    Console.WriteLine("Not enough Stock!!!");
            }

        }
    }
}