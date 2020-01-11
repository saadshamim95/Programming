using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Object_Oriented
{
    class StockPortfolio
    {
        public void Test()
        {
            string strJSONResult = File.ReadAllText(@"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Stock_Management\Stock.json");
            List<Stock> stock = JsonConvert.DeserializeObject<List<Stock>>(strJSONResult);
            int totalValue = 0;
            Console.WriteLine("*************************Stock Management*************************");
            foreach (Stock item in stock)
            {
                int stockTotalValue = 0;
                stockTotalValue = item.Share_Price * item.Number_of_Shares;
                Console.WriteLine("Stock Name: " + item.Share_Name);
                Console.WriteLine("Share Price: " + item.Share_Price);
                Console.WriteLine("Number of Shares: " + item.Number_of_Shares);
                Console.WriteLine("Total Share Value: " + stockTotalValue);
                Console.WriteLine();
                totalValue += stockTotalValue;
            }
            Console.WriteLine("Total Value of all Stocks: " + totalValue);
        }
    }
}